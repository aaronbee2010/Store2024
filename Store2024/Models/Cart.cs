using System;
using System.Collections.Generic;

namespace Store2024.Models;

public class Cart
{
    public int Id { get; set; }
    public required List<Product> Items { get; set; }
}
