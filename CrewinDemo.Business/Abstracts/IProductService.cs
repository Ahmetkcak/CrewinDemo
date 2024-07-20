using CrewinDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Business.Abstracts;

public interface IProductService
{
    Task<List<Product>> GetProductsByCategory(string category);
}
