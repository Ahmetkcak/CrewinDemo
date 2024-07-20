using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Models.Entities;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public double DiscountPercentage { get; set; } 
    public double Rating { get; set; }
    public int Stock { get; set; }
    public List<string> Tags { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public double Weight { get; set; }
    public Dimension Dimensions { get; set; }
    public string WarrantyInformation { get; set; } = string.Empty;
    public string ShippingInformation { get; set; } = string.Empty;
    public string AvailabilityStatus { get; set; } = string.Empty;
    public List<Review> Reviews { get; set; }
    public string ReturnPolicy { get; set; } = string.Empty;
    public int MinimumOrderQuantity { get; set; }
    public Meta Meta { get; set; }
    public List<string> Images { get; set; }
    public string Thumbnail { get; set; } = string.Empty;
}
