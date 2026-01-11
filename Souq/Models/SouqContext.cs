using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Souq.Models;

public partial class SouqContext : DbContext
{
    public SouqContext()
    {
    }

    public SouqContext(DbContextOptions<SouqContext> options)
        : base(options)
    {
    }

    public  DbSet<Product> Products { get; set; }
    public  DbSet<Review> Reviews { get; set; }
    public  DbSet<Category> Categorys { get; set; }
    public  DbSet<Cart> Carts { get; set; }

   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
            

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
