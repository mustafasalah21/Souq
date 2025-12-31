using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Product
{
    public Product()
        {
        Carts = new HashSet<Cart>();

        }
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Describtion { get; set; } = null!;

    public sbyte Price { get; set; }

    public string Photo { get; set; } = null!;

    public string Productcol { get; set; } = null!;

    public int CatId { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category Cat { get; set; } = null!;
}
