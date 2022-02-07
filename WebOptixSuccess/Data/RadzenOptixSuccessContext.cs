using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using CoreBusiness.Models;

namespace WebOptixSuccess.Data
{
  public partial class RadzenOptixSuccessContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public RadzenOptixSuccessContext(DbContextOptions<RadzenOptixSuccessContext> options) : base(options) { }

    public RadzenOptixSuccessContext() { }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ItemOrder>()
              .HasOne(i => i.Product)
              .WithMany(i => i.ItemOrders)
              .HasForeignKey(i => i.ProductId)
              .HasPrincipalKey(i => i.ProductId);
        builder.Entity<ItemOrder>()
              .HasOne(i => i.OrderCustomer)
              .WithMany(i => i.ItemOrders)
              .HasForeignKey(i => i.OrderCustomerId)
              .HasPrincipalKey(i => i.OrderCustomerId);
        builder.Entity<ItemOrder>()
              .HasOne(i => i.OrderVendor)
              .WithMany(i => i.ItemOrders)
              .HasForeignKey(i => i.OrderVendorId)
              .HasPrincipalKey(i => i.OrderVendorId);


        builder.Entity<ItemOrder>()
              .Property(p => p.Edited)
              .HasColumnType("datetime2");

        builder.Entity<OrderCustomer>()
              .Property(p => p.Edited)
              .HasColumnType("datetime2");

        builder.Entity<OrderVendor>()
              .Property(p => p.Edited)
              .HasColumnType("datetime2");

        this.OnModelBuilding(builder);
    }


    public DbSet<Category> Categories { get; set; }    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ItemOrder> ItemOrders { get; set; }
    public DbSet<OrderCustomer> OrderCustomers { get; set; }
    public DbSet<OrderVendor> OrderVendors { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    }
}
