using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Souq.Models;

[Table("product")]
[Index("CatId", Name = "aa_idx")]
public partial class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(45)]
    public string? Name { get; set; }

    [StringLength(450)]
    public string? Describtion { get; set; }

    public sbyte? Price { get; set; }

    [StringLength(45)]
    public string? Photo { get; set; }

    [StringLength(45)]
    public string? SuplierName { get; set; }

    public int? CatId { get; set; }

    public DateOnly? Date { get; set; }

    [StringLength(500)]
    public string? Url { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [ForeignKey("CatId")]
    [InverseProperty("Products")]
    public virtual Category? Cat { get; set; }
}
