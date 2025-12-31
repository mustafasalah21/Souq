using System;
using System.Collections.Generic;

namespace Souq.Models;

public partial class Review
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Description { get; set; } = null!;
}
