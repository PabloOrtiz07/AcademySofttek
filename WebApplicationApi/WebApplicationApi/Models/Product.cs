using System;
using System.Collections.Generic;

namespace WebApplicationApi.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string? ProductName { get; set; }

    public decimal? Price { get; set; }
}
