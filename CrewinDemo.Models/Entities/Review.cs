using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.Models.Entities;

public class Review
{
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string ReviewerName { get; set; } = string.Empty;
    public string ReviewerEmail { get; set; } = string.Empty;
}
