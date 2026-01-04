using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Souq.Models;

[Table("category")]
public partial class Category
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    public string Descrption { get; set; } = null!;

    [StringLength(200)]
    public string Photo { get; set; } = null!;

    [InverseProperty("Cat")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
