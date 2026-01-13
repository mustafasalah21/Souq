using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class OrderDetile
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public decimal? Price { get; set; }

    public int? Qty { get; set; }

    public int? TotelPrice { get; set; }

    public int? OrderId { get; set; }
    public virtual Product? Product { get; set; }

    public virtual Order? Order { get; set; }
}
