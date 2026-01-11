using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Souq.Models;

public partial class SouqDbContext : DbContext
{
    public SouqDbContext()
    {
    }

    public SouqDbContext(DbContextOptions<SouqDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Productimage> Productimages { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Cart> Carts { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     

        modelBuilder.Entity<Productimage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("productimage");

            entity.HasIndex(e => e.Productid, "ad_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .HasColumnName("image");
            entity.Property(e => e.Productid).HasColumnName("productid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
