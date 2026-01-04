using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Souq.Models;

[Table("review")]
public partial class Review
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; } = null!;

    [StringLength(45)]
    public string Email { get; set; } = null!;

    [StringLength(45)]
    public string Subject { get; set; } = null!;

    [StringLength(45)]
    public string Description { get; set; } = null!;
}
