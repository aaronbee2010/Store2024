using System;
using System.Collections.Generic;
namespace Store2024.Models;

public class Commerce
{
    public required Consumer User { get; set; }
    public required List<Product> Products { get; set; }
    public Cart? Cart { get; set; }
}
