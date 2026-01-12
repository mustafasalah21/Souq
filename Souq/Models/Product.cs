using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Describtion { get; set; }

    public byte? Price { get; set; }

    public string? Photo { get; set; }

    public string? SuplierName { get; set; }

    public int? CatId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Cat { get; set; }

    public virtual ICollection<Productimage> Productimages { get; set; } = new List<Productimage>();
}
