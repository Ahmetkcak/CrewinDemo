using CrewinDemo.Business.Abstracts;
using CrewinDemo.Business.Constants;
using CrewinDemo.Models.Entities;
using CrewinDemo.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Business.Services;

public class ProductService(HttpClient httpClient) : IProductService
{
    public async Task<List<Product>> GetProductsByCategory(string category)
    {
        var products = await GetProductFromApi(category);
        return products;
    }

    private async Task<List<Product>> GetProductFromApi(string category)
    {
        var url = $"{ApiEndpoints.ProductsByCategoryUrl}{category}";
        var response = await httpClient.GetStringAsync(url);
        var productResponseModel = JsonConvert.DeserializeObject<ProductResponseModel>(response);
        return productResponseModel?.Products ?? [];
    }
}
