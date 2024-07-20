using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Models.Entities;

public class Category
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
