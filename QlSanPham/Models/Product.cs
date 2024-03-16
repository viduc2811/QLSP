using System;
using System.Collections.Generic;

namespace QlSanPham.Models;

public partial class Product
{
    public int Idpd { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Id { get; set; }

    public virtual Category? IdNavigation { get; set; }
}
