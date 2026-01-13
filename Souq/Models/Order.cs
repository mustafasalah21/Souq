using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Order
{
    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? UserNumber { get; set; }

    public int Id { get; set; }

    public virtual ICollection<OrderDetile> OrderDetiles { get; set; } = new List<OrderDetile>();
}
