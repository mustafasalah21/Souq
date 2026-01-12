using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal? Prise { get; set; }
    public string? IdentityUserId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
