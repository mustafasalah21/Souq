using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Descrption { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
