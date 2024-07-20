using CrewinDemo.DataAccess.Context;
using CrewinDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Business.Repositories;

public interface ICategoryRepository
{
    Task<Category> AddCategory(Category category);
    Task<List<Category>> GetCategories();
}

public class CategoryRepository(CrewinDbContext dbContext) : ICategoryRepository
{
    public Task<Category> AddCategory(Category category)
    {
        dbContext.Categories.AddAsync(category);
        dbContext.SaveChangesAsync();
        return Task.FromResult(category);
    }

    public Task<List<Category>> GetCategories()
    {
        return dbContext.Categories.ToListAsync();
    }
}
