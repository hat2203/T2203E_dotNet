﻿using System;
using System.Collections.Generic;

namespace T2203E_API.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Thumbnail { get; set; }

    public int Qty { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandsId { get; set; }

    public virtual Brand? Brands { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }
}