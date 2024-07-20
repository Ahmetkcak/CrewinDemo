using CrewinDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Business.Abstracts;

public interface ICategoryService
{
    Task<Category> AddCategory(Category category);
    Task<List<Category>> GetCategories();
}
