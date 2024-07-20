using CrewinDemo.Business.Abstracts;
using CrewinDemo.Business.Constants;
using CrewinDemo.Business.Repositories;
using CrewinDemo.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Business.Services;

public class CategoryService(ICategoryRepository categoryRepository,HttpClient httpClient) : ICategoryService
{
    public async Task<Category> AddCategory(Category category)
    {
        Category addedCategory = await categoryRepository.AddCategory(category);
        return addedCategory;
    }

    public async Task<List<Category>> GetCategories()
    {
        var dbCategorieis = await categoryRepository.GetCategories();
        var apiCategories = await GetCategoriesFromApi();

        dbCategorieis.AddRange(apiCategories);
        return dbCategorieis;
    }

    private async Task<List<Category>> GetCategoriesFromApi()
    {
        var response = await httpClient.GetStringAsync(ApiEndpoints.ProductCategoriesUrl);
        var categories = JsonConvert.DeserializeObject<List<Category>>(response);
        return (List<Category>)(categories ?? Enumerable.Empty<Category>());
    }
}
