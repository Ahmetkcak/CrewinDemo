using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Models.Entities;

public class Meta
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Barcode { get; set; } = string.Empty;
    public string QrCode { get; set; } = string.Empty;
}
