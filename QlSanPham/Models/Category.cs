using System;
using System.Collections.Generic;

namespace QlSanPham.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Active { get; set; }

    public string? Displayorder { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
