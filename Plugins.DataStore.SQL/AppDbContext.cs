﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null;
        public DbSet<Product> Products { get; set; } = null;
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<OrderCustomer> OrderCustomers { get; set; } = null;
        public DbSet<ItemOrder> ItemOrders { get; set; } = null;
        public DbSet<OrderVendor> OrderVendors { get; set; } = null;
        public DbSet<Vendor> Vendors { get; set; } = null;

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PC-631\SQLEXPRESS;Initial Catalog=WebOptixSuccess;Integrated Security=True;Pooling=False");
        }

        private Random random = new Random();
        private DateTime RandomDay()
        {
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int limirRow = 10;
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.OrderCustomers)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vendor>()
                .HasMany(c => c.OrderVendors)
                .WithOne(p => p.Vendor)
                .HasForeignKey(p => p.VendorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderCustomer>()
               .HasMany(c => c.ItemOrders)
               .WithOne(p => p.OrderCustomer)
               .HasForeignKey(p => p.OrderCustomerId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderVendor>()
               .HasMany(c => c.ItemOrders)
               .WithOne(p => p.OrderVendor)
               .HasForeignKey(p => p.OrderVendorId)
               .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Product>()
               .HasMany(c => c.ItemOrders)
               .WithOne(p => p.Product)
               .HasForeignKey(p => p.ProductId);

            // seeding some data
            modelBuilder.Entity<Category>().HasData(new[]{
                new Category() { CategoryId = 1, Name = "SofLens 59 6 pk" },
                new Category() { CategoryId = 2, Name = "SofLens Daily Disposable 30 pk" },
                new Category() { CategoryId = 3, Name = "Optima FW 4 pk" }
            });

            modelBuilder.Entity<Product>().HasData(new[]{
                new Product { ProductId = 1, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-0.50", Cell = "C4", Quantity = 1, Price = 1.00, Description = "Описание 1001"},
                #region Product 2-100
new Product { ProductId = 2, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-0.75", Cell = "C5", Quantity = 1, Price = 1.00},
new Product { ProductId = 3, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.00", Cell = "C6", Quantity = 1, Price = 1.00},
new Product { ProductId = 4, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.25", Cell = "C7", Quantity = 1, Price = 1.00},
new Product { ProductId = 5, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.50", Cell = "C8", Quantity = 1, Price = 1.00},
new Product { ProductId = 6, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.75", Cell = "C9", Quantity = 1, Price = 1.00},
new Product { ProductId = 7, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-2.00", Cell = "C10", Quantity = 1, Price = 1.00},
new Product { ProductId = 8, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-2.25", Cell = "C11", Quantity = 1, Price = 1.00},
new Product { ProductId = 9, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-2.50", Cell = "C12", Quantity = 1, Price = 1.00},
new Product { ProductId = 10, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-2.75", Cell = "C13", Quantity = 1, Price = 1.00},
new Product { ProductId = 11, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-3.00", Cell = "C14", Quantity = 1, Price = 1.00},
new Product { ProductId = 12, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-3.25", Cell = "C15", Quantity = 1, Price = 1.00},
new Product { ProductId = 13, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-3.50", Cell = "C16", Quantity = 1, Price = 1.00},
new Product { ProductId = 14, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-3.75", Cell = "C17", Quantity = 1, Price = 1.00},
new Product { ProductId = 15, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-4.00", Cell = "C18", Quantity = 1, Price = 1.00},
new Product { ProductId = 16, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-4.25", Cell = "C19", Quantity = 1, Price = 1.00},
new Product { ProductId = 17, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-4.50", Cell = "C20", Quantity = 1, Price = 1.00},
new Product { ProductId = 18, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-4.75", Cell = "C21", Quantity = 1, Price = 1.00},
new Product { ProductId = 19, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-5.00", Cell = "C22", Quantity = 1, Price = 1.00},
new Product { ProductId = 20, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-5.25", Cell = "C23", Quantity = 1, Price = 1.00},
new Product { ProductId = 21, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-5.50", Cell = "C24", Quantity = 1, Price = 1.00},
new Product { ProductId = 22, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-5.75", Cell = "C25", Quantity = 1, Price = 1.00},
new Product { ProductId = 23, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-6.00", Cell = "C26", Quantity = 1, Price = 1.00},
new Product { ProductId = 24, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-6.50", Cell = "C27", Quantity = 1, Price = 1.00},
new Product { ProductId = 25, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-7.00", Cell = "C28", Quantity = 1, Price = 1.00},
new Product { ProductId = 26, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-7.50", Cell = "C29", Quantity = 1, Price = 1.00},
new Product { ProductId = 27, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-8.00", Cell = "C30", Quantity = 1, Price = 1.00},
new Product { ProductId = 28, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-8.50", Cell = "C31", Quantity = 1, Price = 1.00},
new Product { ProductId = 29, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-9.00", Cell = "C32", Quantity = 1, Price = 1.00},
new Product { ProductId = 30, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 31, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+0.75", Cell = "E5", Quantity = 1, Price = 1.00},
new Product { ProductId = 32, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+1.00", Cell = "E6", Quantity = 1, Price = 1.00},
new Product { ProductId = 33, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+1.25", Cell = "E7", Quantity = 1, Price = 1.00},
new Product { ProductId = 34, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+1.50", Cell = "E8", Quantity = 1, Price = 1.00},
new Product { ProductId = 35, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+1.75", Cell = "E9", Quantity = 1, Price = 1.00},
new Product { ProductId = 36, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+2.00", Cell = "E10", Quantity = 1, Price = 1.00},
new Product { ProductId = 37, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+2.25", Cell = "E11", Quantity = 1, Price = 1.00},
new Product { ProductId = 38, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+2.50", Cell = "E12", Quantity = 1, Price = 1.00},
new Product { ProductId = 39, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+2.75", Cell = "E13", Quantity = 1, Price = 1.00},
new Product { ProductId = 40, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+3.00", Cell = "E14", Quantity = 1, Price = 1.00},
new Product { ProductId = 41, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+3.25", Cell = "E15", Quantity = 1, Price = 1.00},
new Product { ProductId = 42, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+3.50", Cell = "E16", Quantity = 1, Price = 1.00},
new Product { ProductId = 43, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+3.75", Cell = "E17", Quantity = 1, Price = 1.00},
new Product { ProductId = 44, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+4.00", Cell = "E18", Quantity = 1, Price = 1.00},
new Product { ProductId = 45, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+4.25", Cell = "E19", Quantity = 1, Price = 1.00},
new Product { ProductId = 46, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+4.50", Cell = "E20", Quantity = 1, Price = 1.00},
new Product { ProductId = 47, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+4.75", Cell = "E21", Quantity = 1, Price = 1.00},
new Product { ProductId = 48, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+5.00", Cell = "E22", Quantity = 1, Price = 1.00},
new Product { ProductId = 49, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+5.25", Cell = "E23", Quantity = 1, Price = 1.00},
new Product { ProductId = 50, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+5.50", Cell = "E24", Quantity = 1, Price = 1.00},
new Product { ProductId = 51, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+5.75", Cell = "E25", Quantity = 1, Price = 1.00},
new Product { ProductId = 52, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "+6.00", Cell = "E26", Quantity = 1, Price = 1.00},
new Product { ProductId = 53, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 54, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-0.75", Cell = "H5", Quantity = 1, Price = 1.00},
new Product { ProductId = 55, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-1.00", Cell = "H6", Quantity = 1, Price = 1.00},
new Product { ProductId = 56, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-1.25", Cell = "H7", Quantity = 1, Price = 1.00},
new Product { ProductId = 57, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-1.50", Cell = "H8", Quantity = 1, Price = 1.00},
new Product { ProductId = 58, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-1.75", Cell = "H9", Quantity = 1, Price = 1.00},
new Product { ProductId = 59, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-2.00", Cell = "H10", Quantity = 1, Price = 1.00},
new Product { ProductId = 60, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-2.25", Cell = "H11", Quantity = 1, Price = 1.00},
new Product { ProductId = 61, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-2.50", Cell = "H12", Quantity = 1, Price = 1.00},
new Product { ProductId = 62, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-2.75", Cell = "H13", Quantity = 1, Price = 1.00},
new Product { ProductId = 63, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-3.00", Cell = "H14", Quantity = 1, Price = 1.00},
new Product { ProductId = 64, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-3.25", Cell = "H15", Quantity = 1, Price = 1.00},
new Product { ProductId = 65, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-3.50", Cell = "H16", Quantity = 1, Price = 1.00},
new Product { ProductId = 66, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-3.75", Cell = "H17", Quantity = 1, Price = 1.00},
new Product { ProductId = 67, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-4.00", Cell = "H18", Quantity = 1, Price = 1.00},
new Product { ProductId = 68, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-4.25", Cell = "H19", Quantity = 1, Price = 1.00},
new Product { ProductId = 69, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-4.50", Cell = "H20", Quantity = 1, Price = 1.00},
new Product { ProductId = 70, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-4.75", Cell = "H21", Quantity = 1, Price = 1.00},
new Product { ProductId = 71, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-5.00", Cell = "H22", Quantity = 1, Price = 1.00},
new Product { ProductId = 72, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-5.25", Cell = "H23", Quantity = 1, Price = 1.00},
new Product { ProductId = 73, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-5.50", Cell = "H24", Quantity = 1, Price = 1.00},
new Product { ProductId = 74, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-5.75", Cell = "H25", Quantity = 1, Price = 1.00},
new Product { ProductId = 75, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-6.00", Cell = "H26", Quantity = 1, Price = 1.00},
new Product { ProductId = 76, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-6.50", Cell = "H27", Quantity = 1, Price = 1.00},
new Product { ProductId = 77, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-7.00", Cell = "H28", Quantity = 1, Price = 1.00},
new Product { ProductId = 78, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-7.50", Cell = "H29", Quantity = 1, Price = 1.00},
new Product { ProductId = 79, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-8.00", Cell = "H30", Quantity = 1, Price = 1.00},
new Product { ProductId = 80, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-8.50", Cell = "H31", Quantity = 1, Price = 1.00},
new Product { ProductId = 81, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "-9.00", Cell = "H32", Quantity = 1, Price = 1.00},
new Product { ProductId = 82, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 83, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+0.75", Cell = "J5", Quantity = 1, Price = 1.00},
new Product { ProductId = 84, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+1.00", Cell = "J6", Quantity = 1, Price = 1.00},
new Product { ProductId = 85, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+1.25", Cell = "J7", Quantity = 1, Price = 1.00},
new Product { ProductId = 86, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+1.50", Cell = "J8", Quantity = 1, Price = 1.00},
new Product { ProductId = 87, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+1.75", Cell = "J9", Quantity = 1, Price = 1.00},
new Product { ProductId = 88, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+2.00", Cell = "J10", Quantity = 1, Price = 1.00},
new Product { ProductId = 89, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+2.25", Cell = "J11", Quantity = 1, Price = 1.00},
new Product { ProductId = 90, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+2.50", Cell = "J12", Quantity = 1, Price = 1.00},
new Product { ProductId = 91, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+2.75", Cell = "J13", Quantity = 1, Price = 1.00},
new Product { ProductId = 92, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+3.00", Cell = "J14", Quantity = 1, Price = 1.00},
new Product { ProductId = 93, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+3.25", Cell = "J15", Quantity = 1, Price = 1.00},
new Product { ProductId = 94, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+3.50", Cell = "J16", Quantity = 1, Price = 1.00},
new Product { ProductId = 95, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+3.75", Cell = "J17", Quantity = 1, Price = 1.00},
new Product { ProductId = 96, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+4.00", Cell = "J18", Quantity = 1, Price = 1.00},
new Product { ProductId = 97, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+4.25", Cell = "J19", Quantity = 1, Price = 1.00},
new Product { ProductId = 98, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+4.50", Cell = "J20", Quantity = 1, Price = 1.00},
new Product { ProductId = 99, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+4.75", Cell = "J21", Quantity = 1, Price = 1.00},
new Product { ProductId = 100, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+5.00", Cell = "J22", Quantity = 1, Price = 1.00},
new Product { ProductId = 101, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+5.25", Cell = "J23", Quantity = 1, Price = 1.00},
new Product { ProductId = 102, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+5.50", Cell = "J24", Quantity = 1, Price = 1.00},
new Product { ProductId = 103, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+5.75", Cell = "J25", Quantity = 1, Price = 1.00},
new Product { ProductId = 104, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+6.00", Cell = "J26", Quantity = 1, Price = 1.00},
new Product { ProductId = 105, CategoryId = 1, Name = " SofLens Daily Disposable 30 pk", BC = " 8.6", Sph = "+6.50", Cell = "J27", Quantity = 1, Price = 1.00}
#endregion Product 2 - 1xx
                #region Product 1xx - 5xx
/*new Product { ProductId = 106, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 107, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-0.75", Cell = "m5", Quantity = 1, Price = 1.00},
new Product { ProductId = 108, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-1.00", Cell = "m6", Quantity = 1, Price = 1.00},
new Product { ProductId = 109, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-1.25", Cell = "m7", Quantity = 1, Price = 1.00},
new Product { ProductId = 110, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-1.50", Cell = "m8", Quantity = 1, Price = 1.00},
new Product { ProductId = 111, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-1.75", Cell = "m9", Quantity = 1, Price = 1.00},
new Product { ProductId = 112, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-2.00", Cell = "m10", Quantity = 1, Price = 1.00},
new Product { ProductId = 113, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-2.25", Cell = "m11", Quantity = 1, Price = 1.00},
new Product { ProductId = 114, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-2.50", Cell = "m12", Quantity = 1, Price = 1.00},
new Product { ProductId = 115, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-2.75", Cell = "m13", Quantity = 1, Price = 1.00},
new Product { ProductId = 116, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-3.00", Cell = "m14", Quantity = 1, Price = 1.00},
new Product { ProductId = 117, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-3.25", Cell = "m15", Quantity = 1, Price = 1.00},
new Product { ProductId = 118, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-3.50", Cell = "m16", Quantity = 1, Price = 1.00},
new Product { ProductId = 119, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-3.75", Cell = "m17", Quantity = 1, Price = 1.00},
new Product { ProductId = 120, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-4.00", Cell = "m18", Quantity = 1, Price = 1.00},
new Product { ProductId = 121, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-4.25", Cell = "m19", Quantity = 1, Price = 1.00},
new Product { ProductId = 122, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-4.50", Cell = "m20", Quantity = 1, Price = 1.00},
new Product { ProductId = 123, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-4.75", Cell = "m21", Quantity = 1, Price = 1.00},
new Product { ProductId = 124, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-5.00", Cell = "m22", Quantity = 1, Price = 1.00},
new Product { ProductId = 125, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-5.25", Cell = "m23", Quantity = 1, Price = 1.00},
new Product { ProductId = 126, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-5.50", Cell = "m24", Quantity = 1, Price = 1.00},
new Product { ProductId = 127, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-5.75", Cell = "m25", Quantity = 1, Price = 1.00},
new Product { ProductId = 128, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-6.00", Cell = "m26", Quantity = 1, Price = 1.00},
new Product { ProductId = 129, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-6.50", Cell = "m27", Quantity = 1, Price = 1.00},
new Product { ProductId = 130, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-7.00", Cell = "m28", Quantity = 1, Price = 1.00},
new Product { ProductId = 131, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-7.50", Cell = "m29", Quantity = 1, Price = 1.00},
new Product { ProductId = 132, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-8.00", Cell = "m30", Quantity = 1, Price = 1.00},
new Product { ProductId = 133, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-8.50", Cell = "m31", Quantity = 1, Price = 1.00},
new Product { ProductId = 134, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "-9.00", Cell = "m32", Quantity = 1, Price = 1.00},
new Product { ProductId = 135, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 136, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+0.75", Cell = "o5", Quantity = 1, Price = 1.00},
new Product { ProductId = 137, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+1.00", Cell = "o6", Quantity = 1, Price = 1.00},
new Product { ProductId = 138, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+1.25", Cell = "o7", Quantity = 1, Price = 1.00},
new Product { ProductId = 139, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+1.50", Cell = "o8", Quantity = 1, Price = 1.00},
new Product { ProductId = 140, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+1.75", Cell = "o9", Quantity = 1, Price = 1.00},
new Product { ProductId = 141, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+2.00", Cell = "o10", Quantity = 1, Price = 1.00},
new Product { ProductId = 142, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+2.25", Cell = "o11", Quantity = 1, Price = 1.00},
new Product { ProductId = 143, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+2.50", Cell = "o12", Quantity = 1, Price = 1.00},
new Product { ProductId = 144, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+2.75", Cell = "o13", Quantity = 1, Price = 1.00},
new Product { ProductId = 145, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+3.00", Cell = "o14", Quantity = 1, Price = 1.00},
new Product { ProductId = 146, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+3.25", Cell = "o15", Quantity = 1, Price = 1.00},
new Product { ProductId = 147, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+3.50", Cell = "o16", Quantity = 1, Price = 1.00},
new Product { ProductId = 148, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+3.75", Cell = "o17", Quantity = 1, Price = 1.00},
new Product { ProductId = 149, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+4.00", Cell = "o18", Quantity = 1, Price = 1.00},
new Product { ProductId = 150, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+4.25", Cell = "o19", Quantity = 1, Price = 1.00},
new Product { ProductId = 151, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+4.50", Cell = "o20", Quantity = 1, Price = 1.00},
new Product { ProductId = 152, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+4.75", Cell = "o21", Quantity = 1, Price = 1.00},
new Product { ProductId = 153, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+5.00", Cell = "o22", Quantity = 1, Price = 1.00},
new Product { ProductId = 154, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+5.25", Cell = "o23", Quantity = 1, Price = 1.00},
new Product { ProductId = 155, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+5.50", Cell = "o24", Quantity = 1, Price = 1.00},
new Product { ProductId = 156, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+5.75", Cell = "o25", Quantity = 1, Price = 1.00},
new Product { ProductId = 157, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+6.00", Cell = "o26", Quantity = 1, Price = 1.00},
new Product { ProductId = 158, CategoryId = 1, Name = " SofLens Daily Disposable 90 pk", BC = " 8.6", Sph = "+6.50", Cell = "o27", Quantity = 1, Price = 1.00},
new Product { ProductId = 159, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 160, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-0.75", Cell = "r5", Quantity = 1, Price = 1.00},
new Product { ProductId = 161, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-1.00", Cell = "r6", Quantity = 1, Price = 1.00},
new Product { ProductId = 162, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-1.25", Cell = "r7", Quantity = 1, Price = 1.00},
new Product { ProductId = 163, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-1.50", Cell = "r8", Quantity = 1, Price = 1.00},
new Product { ProductId = 164, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-1.75", Cell = "r9", Quantity = 1, Price = 1.00},
new Product { ProductId = 165, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-2.00", Cell = "r10", Quantity = 1, Price = 1.00},
new Product { ProductId = 166, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-2.25", Cell = "r11", Quantity = 1, Price = 1.00},
new Product { ProductId = 167, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-2.50", Cell = "r12", Quantity = 1, Price = 1.00},
new Product { ProductId = 168, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-2.75", Cell = "r13", Quantity = 1, Price = 1.00},
new Product { ProductId = 169, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-3.00", Cell = "r14", Quantity = 1, Price = 1.00},
new Product { ProductId = 170, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-3.25", Cell = "r15", Quantity = 1, Price = 1.00},
new Product { ProductId = 171, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-3.50", Cell = "r16", Quantity = 1, Price = 1.00},
new Product { ProductId = 172, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-3.75", Cell = "r17", Quantity = 1, Price = 1.00},
new Product { ProductId = 173, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-4.00", Cell = "r18", Quantity = 1, Price = 1.00},
new Product { ProductId = 174, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-4.25", Cell = "r19", Quantity = 1, Price = 1.00},
new Product { ProductId = 175, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-4.50", Cell = "r20", Quantity = 1, Price = 1.00},
new Product { ProductId = 176, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-4.75", Cell = "r21", Quantity = 1, Price = 1.00},
new Product { ProductId = 177, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-5.00", Cell = "r22", Quantity = 1, Price = 1.00},
new Product { ProductId = 178, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-5.25", Cell = "r23", Quantity = 1, Price = 1.00},
new Product { ProductId = 179, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-5.50", Cell = "r24", Quantity = 1, Price = 1.00},
new Product { ProductId = 180, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-5.75", Cell = "r25", Quantity = 1, Price = 1.00},
new Product { ProductId = 181, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-6.00", Cell = "r26", Quantity = 1, Price = 1.00},
new Product { ProductId = 182, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-6.50", Cell = "r27", Quantity = 1, Price = 1.00},
new Product { ProductId = 183, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-7.00", Cell = "r28", Quantity = 1, Price = 1.00},
new Product { ProductId = 184, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-7.50", Cell = "r29", Quantity = 1, Price = 1.00},
new Product { ProductId = 185, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-8.00", Cell = "r30", Quantity = 1, Price = 1.00},
new Product { ProductId = 186, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-8.50", Cell = "r31", Quantity = 1, Price = 1.00},
new Product { ProductId = 187, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.4", Sph = "-9.00", Cell = "r32", Quantity = 1, Price = 1.00},
new Product { ProductId = 188, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 189, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-0.75", Cell = "s5", Quantity = 1, Price = 1.00},
new Product { ProductId = 190, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-1.00", Cell = "s6", Quantity = 1, Price = 1.00},
new Product { ProductId = 191, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-1.25", Cell = "s7", Quantity = 1, Price = 1.00},
new Product { ProductId = 192, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-1.50", Cell = "s8", Quantity = 1, Price = 1.00},
new Product { ProductId = 193, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-1.75", Cell = "s9", Quantity = 1, Price = 1.00},
new Product { ProductId = 194, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-2.00", Cell = "s10", Quantity = 1, Price = 1.00},
new Product { ProductId = 195, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-2.25", Cell = "s11", Quantity = 1, Price = 1.00},
new Product { ProductId = 196, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-2.50", Cell = "s12", Quantity = 1, Price = 1.00},
new Product { ProductId = 197, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-2.75", Cell = "s13", Quantity = 1, Price = 1.00},
new Product { ProductId = 198, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-3.00", Cell = "s14", Quantity = 1, Price = 1.00},
new Product { ProductId = 199, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-3.25", Cell = "s15", Quantity = 1, Price = 1.00},
new Product { ProductId = 200, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-3.50", Cell = "s16", Quantity = 1, Price = 1.00},
new Product { ProductId = 201, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-3.75", Cell = "s17", Quantity = 1, Price = 1.00},
new Product { ProductId = 202, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-4.00", Cell = "s18", Quantity = 1, Price = 1.00},
new Product { ProductId = 203, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-4.25", Cell = "s19", Quantity = 1, Price = 1.00},
new Product { ProductId = 204, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-4.50", Cell = "s20", Quantity = 1, Price = 1.00},
new Product { ProductId = 205, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-4.75", Cell = "s21", Quantity = 1, Price = 1.00},
new Product { ProductId = 206, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-5.00", Cell = "s22", Quantity = 1, Price = 1.00},
new Product { ProductId = 207, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-5.25", Cell = "s23", Quantity = 1, Price = 1.00},
new Product { ProductId = 208, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-5.50", Cell = "s24", Quantity = 1, Price = 1.00},
new Product { ProductId = 209, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-5.75", Cell = "s25", Quantity = 1, Price = 1.00},
new Product { ProductId = 210, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-6.00", Cell = "s26", Quantity = 1, Price = 1.00},
new Product { ProductId = 211, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-6.50", Cell = "s27", Quantity = 1, Price = 1.00},
new Product { ProductId = 212, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-7.00", Cell = "s28", Quantity = 1, Price = 1.00},
new Product { ProductId = 213, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-7.50", Cell = "s29", Quantity = 1, Price = 1.00},
new Product { ProductId = 214, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-8.00", Cell = "s30", Quantity = 1, Price = 1.00},
new Product { ProductId = 215, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-8.50", Cell = "s31", Quantity = 1, Price = 1.00},
new Product { ProductId = 216, CategoryId = 1, Name = "Optima FW 4 pk", BC = " 8.7", Sph = "-9.00", Cell = "s32", Quantity = 1, Price = 1.00},
new Product { ProductId = 217, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 218, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-0.75", Cell = "t5", Quantity = 1, Price = 1.00},
new Product { ProductId = 219, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-1.00", Cell = "t6", Quantity = 1, Price = 1.00},
new Product { ProductId = 220, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-1.25", Cell = "t7", Quantity = 1, Price = 1.00},
new Product { ProductId = 221, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-1.50", Cell = "t8", Quantity = 1, Price = 1.00},
new Product { ProductId = 222, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-1.75", Cell = "t9", Quantity = 1, Price = 1.00},
new Product { ProductId = 223, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-2.00", Cell = "t10", Quantity = 1, Price = 1.00},
new Product { ProductId = 224, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-2.25", Cell = "t11", Quantity = 1, Price = 1.00},
new Product { ProductId = 225, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-2.50", Cell = "t12", Quantity = 1, Price = 1.00},
new Product { ProductId = 226, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-2.75", Cell = "t13", Quantity = 1, Price = 1.00},
new Product { ProductId = 227, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-3.00", Cell = "t14", Quantity = 1, Price = 1.00},
new Product { ProductId = 228, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-3.25", Cell = "t15", Quantity = 1, Price = 1.00},
new Product { ProductId = 229, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-3.50", Cell = "t16", Quantity = 1, Price = 1.00},
new Product { ProductId = 230, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-3.75", Cell = "t17", Quantity = 1, Price = 1.00},
new Product { ProductId = 231, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-4.00", Cell = "t18", Quantity = 1, Price = 1.00},
new Product { ProductId = 232, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-4.25", Cell = "t19", Quantity = 1, Price = 1.00},
new Product { ProductId = 233, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-4.50", Cell = "t20", Quantity = 1, Price = 1.00},
new Product { ProductId = 234, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-4.75", Cell = "t21", Quantity = 1, Price = 1.00},
new Product { ProductId = 235, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-5.00", Cell = "t22", Quantity = 1, Price = 1.00},
new Product { ProductId = 236, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-5.25", Cell = "t23", Quantity = 1, Price = 1.00},
new Product { ProductId = 237, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-5.50", Cell = "t24", Quantity = 1, Price = 1.00},
new Product { ProductId = 238, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-5.75", Cell = "t25", Quantity = 1, Price = 1.00},
new Product { ProductId = 239, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-6.00", Cell = "t26", Quantity = 1, Price = 1.00},
new Product { ProductId = 240, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-6.50", Cell = "t27", Quantity = 1, Price = 1.00},
new Product { ProductId = 241, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-7.00", Cell = "t28", Quantity = 1, Price = 1.00},
new Product { ProductId = 242, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-7.50", Cell = "t29", Quantity = 1, Price = 1.00},
new Product { ProductId = 243, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-8.00", Cell = "t30", Quantity = 1, Price = 1.00},
new Product { ProductId = 244, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-8.50", Cell = "t31", Quantity = 1, Price = 1.00},
new Product { ProductId = 245, CategoryId = 1, Name = "Optima FW 4 pk", BC = "9.0", Sph = "-9.00", Cell = "t32", Quantity = 1, Price = 1.00},
new Product { ProductId = 246, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 247, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-0.50", Cell = "x5", Quantity = 1, Price = 1.00},
new Product { ProductId = 248, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-0.75", Cell = "x6", Quantity = 1, Price = 1.00},
new Product { ProductId = 249, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-1.00", Cell = "x7", Quantity = 1, Price = 1.00},
new Product { ProductId = 250, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-1.25", Cell = "x8", Quantity = 1, Price = 1.00},
new Product { ProductId = 251, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-1.50", Cell = "x9", Quantity = 1, Price = 1.00},
new Product { ProductId = 252, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-1.75", Cell = "x10", Quantity = 1, Price = 1.00},
new Product { ProductId = 253, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-2.00", Cell = "x11", Quantity = 1, Price = 1.00},
new Product { ProductId = 254, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-2.25", Cell = "x12", Quantity = 1, Price = 1.00},
new Product { ProductId = 255, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-2.50", Cell = "x13", Quantity = 1, Price = 1.00},
new Product { ProductId = 256, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-2.75", Cell = "x14", Quantity = 1, Price = 1.00},
new Product { ProductId = 257, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-3.00", Cell = "x15", Quantity = 1, Price = 1.00},
new Product { ProductId = 258, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-3.25", Cell = "x16", Quantity = 1, Price = 1.00},
new Product { ProductId = 259, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-3.50", Cell = "x17", Quantity = 1, Price = 1.00},
new Product { ProductId = 260, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-3.75", Cell = "x18", Quantity = 1, Price = 1.00},
new Product { ProductId = 261, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-4.00", Cell = "x19", Quantity = 1, Price = 1.00},
new Product { ProductId = 262, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-4.25", Cell = "x20", Quantity = 1, Price = 1.00},
new Product { ProductId = 263, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-4.50", Cell = "x21", Quantity = 1, Price = 1.00},
new Product { ProductId = 264, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-4.75", Cell = "x22", Quantity = 1, Price = 1.00},
new Product { ProductId = 265, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-5.00", Cell = "x23", Quantity = 1, Price = 1.00},
new Product { ProductId = 266, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-5.25", Cell = "x24", Quantity = 1, Price = 1.00},
new Product { ProductId = 267, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-5.50", Cell = "x25", Quantity = 1, Price = 1.00},
new Product { ProductId = 268, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-5.75", Cell = "x26", Quantity = 1, Price = 1.00},
new Product { ProductId = 269, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-6.00", Cell = "x27", Quantity = 1, Price = 1.00},
new Product { ProductId = 270, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-6.50", Cell = "x28", Quantity = 1, Price = 1.00},
new Product { ProductId = 271, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-7.00", Cell = "x29", Quantity = 1, Price = 1.00},
new Product { ProductId = 272, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-7.50", Cell = "x30", Quantity = 1, Price = 1.00},
new Product { ProductId = 273, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-8.00", Cell = "x31", Quantity = 1, Price = 1.00},
new Product { ProductId = 274, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-8.50", Cell = "x32", Quantity = 1, Price = 1.00},
new Product { ProductId = 275, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-9.00", Cell = "x33", Quantity = 1, Price = 1.00},
new Product { ProductId = 276, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-9.50", Cell = "x34", Quantity = 1, Price = 1.00},
new Product { ProductId = 277, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-10.00", Cell = "x35", Quantity = 1, Price = 1.00},
new Product { ProductId = 278, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-10.50", Cell = "x36", Quantity = 1, Price = 1.00},
new Product { ProductId = 279, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-11.00", Cell = "x37", Quantity = 1, Price = 1.00},
new Product { ProductId = 280, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-11.50", Cell = "x38", Quantity = 1, Price = 1.00},
new Product { ProductId = 281, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "-12.00", Cell = "x39", Quantity = 1, Price = 1.00},
new Product { ProductId = 282, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 283, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+0.50", Cell = "z5", Quantity = 1, Price = 1.00},
new Product { ProductId = 284, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+0.75", Cell = "z6", Quantity = 1, Price = 1.00},
new Product { ProductId = 285, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+1.00", Cell = "z7", Quantity = 1, Price = 1.00},
new Product { ProductId = 286, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+1.25", Cell = "z8", Quantity = 1, Price = 1.00},
new Product { ProductId = 287, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+1.50", Cell = "z9", Quantity = 1, Price = 1.00},
new Product { ProductId = 288, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+1.75", Cell = "z10", Quantity = 1, Price = 1.00},
new Product { ProductId = 289, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+2.00", Cell = "z11", Quantity = 1, Price = 1.00},
new Product { ProductId = 290, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+2.25", Cell = "z12", Quantity = 1, Price = 1.00},
new Product { ProductId = 291, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+2.50", Cell = "z13", Quantity = 1, Price = 1.00},
new Product { ProductId = 292, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+2.75", Cell = "z14", Quantity = 1, Price = 1.00},
new Product { ProductId = 293, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+3.00", Cell = "z15", Quantity = 1, Price = 1.00},
new Product { ProductId = 294, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+3.25", Cell = "z16", Quantity = 1, Price = 1.00},
new Product { ProductId = 295, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+3.50", Cell = "z17", Quantity = 1, Price = 1.00},
new Product { ProductId = 296, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+3.75", Cell = "z18", Quantity = 1, Price = 1.00},
new Product { ProductId = 297, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+4.00", Cell = "z19", Quantity = 1, Price = 1.00},
new Product { ProductId = 298, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+4.25", Cell = "z20", Quantity = 1, Price = 1.00},
new Product { ProductId = 299, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+4.50", Cell = "z21", Quantity = 1, Price = 1.00},
new Product { ProductId = 300, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+4.75", Cell = "z22", Quantity = 1, Price = 1.00},
new Product { ProductId = 301, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+5.00", Cell = "z23", Quantity = 1, Price = 1.00},
new Product { ProductId = 302, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+5.25", Cell = "z24", Quantity = 1, Price = 1.00},
new Product { ProductId = 303, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+5.50", Cell = "z25", Quantity = 1, Price = 1.00},
new Product { ProductId = 304, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+5.75", Cell = "z26", Quantity = 1, Price = 1.00},
new Product { ProductId = 305, CategoryId = 1, Name = "Pure Vision2 6pk", BC = " 8.6", Sph = "+6.00", Cell = "z27", Quantity = 1, Price = 1.00},
new Product { ProductId = 306, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 307, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-0.50", Cell = "ac5", Quantity = 1, Price = 1.00},
new Product { ProductId = 308, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-0.75", Cell = "ac6", Quantity = 1, Price = 1.00},
new Product { ProductId = 309, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-1.00", Cell = "ac7", Quantity = 1, Price = 1.00},
new Product { ProductId = 310, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-1.25", Cell = "ac8", Quantity = 1, Price = 1.00},
new Product { ProductId = 311, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-1.50", Cell = "ac9", Quantity = 1, Price = 1.00},
new Product { ProductId = 312, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-1.75", Cell = "ac10", Quantity = 1, Price = 1.00},
new Product { ProductId = 313, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-2.00", Cell = "ac11", Quantity = 1, Price = 1.00},
new Product { ProductId = 314, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-2.25", Cell = "ac12", Quantity = 1, Price = 1.00},
new Product { ProductId = 315, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-2.50", Cell = "ac13", Quantity = 1, Price = 1.00},
new Product { ProductId = 316, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-2.75", Cell = "ac14", Quantity = 1, Price = 1.00},
new Product { ProductId = 317, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-3.00", Cell = "ac15", Quantity = 1, Price = 1.00},
new Product { ProductId = 318, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-3.25", Cell = "ac16", Quantity = 1, Price = 1.00},
new Product { ProductId = 319, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-3.50", Cell = "ac17", Quantity = 1, Price = 1.00},
new Product { ProductId = 320, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-3.75", Cell = "ac18", Quantity = 1, Price = 1.00},
new Product { ProductId = 321, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-4.00", Cell = "ac19", Quantity = 1, Price = 1.00},
new Product { ProductId = 322, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-4.25", Cell = "ac20", Quantity = 1, Price = 1.00},
new Product { ProductId = 323, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-4.50", Cell = "ac21", Quantity = 1, Price = 1.00},
new Product { ProductId = 324, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-4.75", Cell = "ac22", Quantity = 1, Price = 1.00},
new Product { ProductId = 325, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-5.00", Cell = "ac23", Quantity = 1, Price = 1.00},
new Product { ProductId = 326, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-5.25", Cell = "ac24", Quantity = 1, Price = 1.00},
new Product { ProductId = 327, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-5.50", Cell = "ac25", Quantity = 1, Price = 1.00},
new Product { ProductId = 328, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-5.75", Cell = "ac26", Quantity = 1, Price = 1.00},
new Product { ProductId = 329, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-6.00", Cell = "ac27", Quantity = 1, Price = 1.00},
new Product { ProductId = 330, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-6.25", Cell = "ac28", Quantity = 1, Price = 1.00},
new Product { ProductId = 331, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-6.50", Cell = "ac29", Quantity = 1, Price = 1.00},
new Product { ProductId = 332, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-7.00", Cell = "ac30", Quantity = 1, Price = 1.00},
new Product { ProductId = 333, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-7.50", Cell = "ac31", Quantity = 1, Price = 1.00},
new Product { ProductId = 334, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-8.00", Cell = "ac32", Quantity = 1, Price = 1.00},
new Product { ProductId = 335, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-8.50", Cell = "ac33", Quantity = 1, Price = 1.00},
new Product { ProductId = 336, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-9.00", Cell = "ac34", Quantity = 1, Price = 1.00},
new Product { ProductId = 337, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 338, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+0.50", Cell = "ae5", Quantity = 1, Price = 1.00},
new Product { ProductId = 339, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+0.75", Cell = "ae6", Quantity = 1, Price = 1.00},
new Product { ProductId = 340, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+1.00", Cell = "ae7", Quantity = 1, Price = 1.00},
new Product { ProductId = 341, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+1.25", Cell = "ae8", Quantity = 1, Price = 1.00},
new Product { ProductId = 342, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+1.50", Cell = "ae9", Quantity = 1, Price = 1.00},
new Product { ProductId = 343, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+1.75", Cell = "ae10", Quantity = 1, Price = 1.00},
new Product { ProductId = 344, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+2.00", Cell = "ae11", Quantity = 1, Price = 1.00},
new Product { ProductId = 345, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+2.25", Cell = "ae12", Quantity = 1, Price = 1.00},
new Product { ProductId = 346, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+2.50", Cell = "ae13", Quantity = 1, Price = 1.00},
new Product { ProductId = 347, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+2.75", Cell = "ae14", Quantity = 1, Price = 1.00},
new Product { ProductId = 348, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+3.00", Cell = "ae15", Quantity = 1, Price = 1.00},
new Product { ProductId = 349, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+3.25", Cell = "ae16", Quantity = 1, Price = 1.00},
new Product { ProductId = 350, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+3.50", Cell = "ae17", Quantity = 1, Price = 1.00},
new Product { ProductId = 351, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+3.75", Cell = "ae18", Quantity = 1, Price = 1.00},
new Product { ProductId = 352, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+4.00", Cell = "ae19", Quantity = 1, Price = 1.00},
new Product { ProductId = 353, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+4.25", Cell = "ae20", Quantity = 1, Price = 1.00},
new Product { ProductId = 354, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+4.50", Cell = "ae21", Quantity = 1, Price = 1.00},
new Product { ProductId = 355, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+4.75", Cell = "ae22", Quantity = 1, Price = 1.00},
new Product { ProductId = 356, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+5.00", Cell = "ae23", Quantity = 1, Price = 1.00},
new Product { ProductId = 357, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+5.25", Cell = "ae24", Quantity = 1, Price = 1.00},
new Product { ProductId = 358, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+5.50", Cell = "ae25", Quantity = 1, Price = 1.00},
new Product { ProductId = 359, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+5.75", Cell = "ae26", Quantity = 1, Price = 1.00},
new Product { ProductId = 360, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+6.00", Cell = "ae27", Quantity = 1, Price = 1.00},
new Product { ProductId = 361, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "-6.25", Cell = "ae28", Quantity = 1, Price = 1.00},
new Product { ProductId = 362, CategoryId = 1, Name = "Biotrue ONEDay 30pk", BC = " 8.6", Sph = "+6.50", Cell = "ae29", Quantity = 1, Price = 1.00},
new Product { ProductId = 363, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 364, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-0.50", Cell = "ag5", Quantity = 1, Price = 1.00},
new Product { ProductId = 365, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-0.75", Cell = "ag6", Quantity = 1, Price = 1.00},
new Product { ProductId = 366, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-1.00", Cell = "ag7", Quantity = 1, Price = 1.00},
new Product { ProductId = 367, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-1.25", Cell = "ag8", Quantity = 1, Price = 1.00},
new Product { ProductId = 368, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-1.50", Cell = "ag9", Quantity = 1, Price = 1.00},
new Product { ProductId = 369, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-1.75", Cell = "ag10", Quantity = 1, Price = 1.00},
new Product { ProductId = 370, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-2.00", Cell = "ag11", Quantity = 1, Price = 1.00},
new Product { ProductId = 371, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-2.25", Cell = "ag12", Quantity = 1, Price = 1.00},
new Product { ProductId = 372, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-2.50", Cell = "ag13", Quantity = 1, Price = 1.00},
new Product { ProductId = 373, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-2.75", Cell = "ag14", Quantity = 1, Price = 1.00},
new Product { ProductId = 374, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-3.00", Cell = "ag15", Quantity = 1, Price = 1.00},
new Product { ProductId = 375, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-3.25", Cell = "ag16", Quantity = 1, Price = 1.00},
new Product { ProductId = 376, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-3.50", Cell = "ag17", Quantity = 1, Price = 1.00},
new Product { ProductId = 377, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-3.75", Cell = "ag18", Quantity = 1, Price = 1.00},
new Product { ProductId = 378, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-4.00", Cell = "ag19", Quantity = 1, Price = 1.00},
new Product { ProductId = 379, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-4.25", Cell = "ag20", Quantity = 1, Price = 1.00},
new Product { ProductId = 380, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-4.50", Cell = "ag21", Quantity = 1, Price = 1.00},
new Product { ProductId = 381, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-4.75", Cell = "ag22", Quantity = 1, Price = 1.00},
new Product { ProductId = 382, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-5.00", Cell = "ag23", Quantity = 1, Price = 1.00},
new Product { ProductId = 383, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-5.25", Cell = "ag24", Quantity = 1, Price = 1.00},
new Product { ProductId = 384, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-5.50", Cell = "ag25", Quantity = 1, Price = 1.00},
new Product { ProductId = 385, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-5.75", Cell = "ag26", Quantity = 1, Price = 1.00},
new Product { ProductId = 386, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-6.00", Cell = "ag27", Quantity = 1, Price = 1.00},
new Product { ProductId = 387, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-6.25", Cell = "ag28", Quantity = 1, Price = 1.00},
new Product { ProductId = 388, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-6.50", Cell = "ag29", Quantity = 1, Price = 1.00},
new Product { ProductId = 389, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-7.00", Cell = "ag30", Quantity = 1, Price = 1.00},
new Product { ProductId = 390, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-7.50", Cell = "ag31", Quantity = 1, Price = 1.00},
new Product { ProductId = 391, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-8.00", Cell = "ag32", Quantity = 1, Price = 1.00},
new Product { ProductId = 392, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-8.50", Cell = "ag33", Quantity = 1, Price = 1.00},
new Product { ProductId = 393, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "-9.00", Cell = "ag34", Quantity = 1, Price = 1.00},
new Product { ProductId = 394, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 395, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+0.50", Cell = "ai5", Quantity = 1, Price = 1.00},
new Product { ProductId = 396, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+0.75", Cell = "ai6", Quantity = 1, Price = 1.00},
new Product { ProductId = 397, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+1.00", Cell = "ai7", Quantity = 1, Price = 1.00},
new Product { ProductId = 398, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+1.25", Cell = "ai8", Quantity = 1, Price = 1.00},
new Product { ProductId = 399, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+1.50", Cell = "ai9", Quantity = 1, Price = 1.00},
new Product { ProductId = 400, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+1.75", Cell = "ai10", Quantity = 1, Price = 1.00},
new Product { ProductId = 401, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+2.00", Cell = "ai11", Quantity = 1, Price = 1.00},
new Product { ProductId = 402, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+2.25", Cell = "ai12", Quantity = 1, Price = 1.00},
new Product { ProductId = 403, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+2.50", Cell = "ai13", Quantity = 1, Price = 1.00},
new Product { ProductId = 404, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+2.75", Cell = "ai14", Quantity = 1, Price = 1.00},
new Product { ProductId = 405, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+3.00", Cell = "ai15", Quantity = 1, Price = 1.00},
new Product { ProductId = 406, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+3.25", Cell = "ai16", Quantity = 1, Price = 1.00},
new Product { ProductId = 407, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+3.50", Cell = "ai17", Quantity = 1, Price = 1.00},
new Product { ProductId = 408, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+3.75", Cell = "ai18", Quantity = 1, Price = 1.00},
new Product { ProductId = 409, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+4.00", Cell = "ai19", Quantity = 1, Price = 1.00},
new Product { ProductId = 410, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+4.25", Cell = "ai20", Quantity = 1, Price = 1.00},
new Product { ProductId = 411, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+4.50", Cell = "ai21", Quantity = 1, Price = 1.00},
new Product { ProductId = 412, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+4.75", Cell = "ai22", Quantity = 1, Price = 1.00},
new Product { ProductId = 413, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+5.00", Cell = "ai23", Quantity = 1, Price = 1.00},
new Product { ProductId = 414, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+5.25", Cell = "ai24", Quantity = 1, Price = 1.00},
new Product { ProductId = 415, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+5.50", Cell = "ai25", Quantity = 1, Price = 1.00},
new Product { ProductId = 416, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+5.75", Cell = "ai26", Quantity = 1, Price = 1.00},
new Product { ProductId = 417, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+6.00", Cell = "ai27", Quantity = 1, Price = 1.00},
new Product { ProductId = 418, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+6.50", Cell = "ai28", Quantity = 1, Price = 1.00},
new Product { ProductId = 419, CategoryId = 1, Name = "Biotrue ONEDay 90pk", BC = " 8.6", Sph = "+6.50", Cell = "ai29", Quantity = 1, Price = 1.00},
new Product { ProductId = 420, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 421, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-0.25", Cell = "al5", Quantity = 1, Price = 1.00},
new Product { ProductId = 422, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-0.50", Cell = "al6", Quantity = 1, Price = 1.00},
new Product { ProductId = 423, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-0.75", Cell = "al7", Quantity = 1, Price = 1.00},
new Product { ProductId = 424, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-1.00", Cell = "al8", Quantity = 1, Price = 1.00},
new Product { ProductId = 425, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-1.25", Cell = "al9", Quantity = 1, Price = 1.00},
new Product { ProductId = 426, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-1.50", Cell = "al10", Quantity = 1, Price = 1.00},
new Product { ProductId = 427, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-1.75", Cell = "al11", Quantity = 1, Price = 1.00},
new Product { ProductId = 428, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-2.00", Cell = "al12", Quantity = 1, Price = 1.00},
new Product { ProductId = 429, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-2.25", Cell = "al13", Quantity = 1, Price = 1.00},
new Product { ProductId = 430, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-2.50", Cell = "al14", Quantity = 1, Price = 1.00},
new Product { ProductId = 431, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-2.75", Cell = "al15", Quantity = 1, Price = 1.00},
new Product { ProductId = 432, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-3.00", Cell = "al16", Quantity = 1, Price = 1.00},
new Product { ProductId = 433, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-3.25", Cell = "al17", Quantity = 1, Price = 1.00},
new Product { ProductId = 434, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-3.50", Cell = "al18", Quantity = 1, Price = 1.00},
new Product { ProductId = 435, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-3.75", Cell = "al19", Quantity = 1, Price = 1.00},
new Product { ProductId = 436, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-4.00", Cell = "al20", Quantity = 1, Price = 1.00},
new Product { ProductId = 437, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-4.25", Cell = "al21", Quantity = 1, Price = 1.00},
new Product { ProductId = 438, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-4.50", Cell = "al22", Quantity = 1, Price = 1.00},
new Product { ProductId = 439, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-4.75", Cell = "al23", Quantity = 1, Price = 1.00},
new Product { ProductId = 440, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-5.00", Cell = "al24", Quantity = 1, Price = 1.00},
new Product { ProductId = 441, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-5.25", Cell = "al25", Quantity = 1, Price = 1.00},
new Product { ProductId = 442, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-5.50", Cell = "al26", Quantity = 1, Price = 1.00},
new Product { ProductId = 443, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-5.75", Cell = "al27", Quantity = 1, Price = 1.00},
new Product { ProductId = 444, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-6.00", Cell = "al28", Quantity = 1, Price = 1.00},
new Product { ProductId = 445, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-6.50", Cell = "al29", Quantity = 1, Price = 1.00},
new Product { ProductId = 446, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-7.00", Cell = "al30", Quantity = 1, Price = 1.00},
new Product { ProductId = 447, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-7.50", Cell = "al31", Quantity = 1, Price = 1.00},
new Product { ProductId = 448, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-8.00", Cell = "al32", Quantity = 1, Price = 1.00},
new Product { ProductId = 449, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-8.50", Cell = "al33", Quantity = 1, Price = 1.00},
new Product { ProductId = 450, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-9.00", Cell = "al34", Quantity = 1, Price = 1.00},
new Product { ProductId = 451, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-9.50", Cell = "al35", Quantity = 1, Price = 1.00},
new Product { ProductId = 452, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-10.00", Cell = "al36", Quantity = 1, Price = 1.00},
new Product { ProductId = 453, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-10.50", Cell = "al37", Quantity = 1, Price = 1.00},
new Product { ProductId = 454, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-11.00", Cell = "al38", Quantity = 1, Price = 1.00},
new Product { ProductId = 455, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-11.50", Cell = "al39", Quantity = 1, Price = 1.00},
new Product { ProductId = 456, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "-12.00", Cell = "al40", Quantity = 1, Price = 1.00},
new Product { ProductId = 457, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 458, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+0.25", Cell = "an5", Quantity = 1, Price = 1.00},
new Product { ProductId = 459, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+0.50", Cell = "an6", Quantity = 1, Price = 1.00},
new Product { ProductId = 460, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+0.75", Cell = "an7", Quantity = 1, Price = 1.00},
new Product { ProductId = 461, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+1.00", Cell = "an8", Quantity = 1, Price = 1.00},
new Product { ProductId = 462, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+1.25", Cell = "an9", Quantity = 1, Price = 1.00},
new Product { ProductId = 463, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+1.50", Cell = "an10", Quantity = 1, Price = 1.00},
new Product { ProductId = 464, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+1.75", Cell = "an11", Quantity = 1, Price = 1.00},
new Product { ProductId = 465, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+2.00", Cell = "an12", Quantity = 1, Price = 1.00},
new Product { ProductId = 466, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+2.25", Cell = "an13", Quantity = 1, Price = 1.00},
new Product { ProductId = 467, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+2.50", Cell = "an14", Quantity = 1, Price = 1.00},
new Product { ProductId = 468, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+2.75", Cell = "an15", Quantity = 1, Price = 1.00},
new Product { ProductId = 469, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+3.00", Cell = "an16", Quantity = 1, Price = 1.00},
new Product { ProductId = 470, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+3.25", Cell = "an17", Quantity = 1, Price = 1.00},
new Product { ProductId = 471, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+3.50", Cell = "an18", Quantity = 1, Price = 1.00},
new Product { ProductId = 472, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+3.75", Cell = "an19", Quantity = 1, Price = 1.00},
new Product { ProductId = 473, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+4.00", Cell = "an20", Quantity = 1, Price = 1.00},
new Product { ProductId = 474, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+4.25", Cell = "an21", Quantity = 1, Price = 1.00},
new Product { ProductId = 475, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+4.50", Cell = "an22", Quantity = 1, Price = 1.00},
new Product { ProductId = 476, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+4.75", Cell = "an23", Quantity = 1, Price = 1.00},
new Product { ProductId = 477, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+5.00", Cell = "an24", Quantity = 1, Price = 1.00},
new Product { ProductId = 478, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+5.25", Cell = "an25", Quantity = 1, Price = 1.00},
new Product { ProductId = 479, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+5.50", Cell = "an26", Quantity = 1, Price = 1.00},
new Product { ProductId = 480, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+5.75", Cell = "an27", Quantity = 1, Price = 1.00},
new Product { ProductId = 481, CategoryId = 1, Name = "ULTRA 3pk", BC = " 8.5", Sph = "+6.00", Cell = "an28", Quantity = 1, Price = 1.00},
new Product { ProductId = 482, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 483, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-0.25", Cell = "aq5", Quantity = 1, Price = 1.00},
new Product { ProductId = 484, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-0.50", Cell = "aq6", Quantity = 1, Price = 1.00},
new Product { ProductId = 485, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-0.75", Cell = "aq7", Quantity = 1, Price = 1.00},
new Product { ProductId = 486, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-1.00", Cell = "aq8", Quantity = 1, Price = 1.00},
new Product { ProductId = 487, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-1.25", Cell = "aq9", Quantity = 1, Price = 1.00},
new Product { ProductId = 488, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-1.50", Cell = "aq10", Quantity = 1, Price = 1.00},
new Product { ProductId = 489, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-1.75", Cell = "aq11", Quantity = 1, Price = 1.00},
new Product { ProductId = 490, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-2.00", Cell = "aq12", Quantity = 1, Price = 1.00},
new Product { ProductId = 491, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-2.25", Cell = "aq13", Quantity = 1, Price = 1.00},
new Product { ProductId = 492, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-2.50", Cell = "aq14", Quantity = 1, Price = 1.00},
new Product { ProductId = 493, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-2.75", Cell = "aq15", Quantity = 1, Price = 1.00},
new Product { ProductId = 494, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-3.00", Cell = "aq16", Quantity = 1, Price = 1.00},
new Product { ProductId = 495, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-3.25", Cell = "aq17", Quantity = 1, Price = 1.00},
new Product { ProductId = 496, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-3.50", Cell = "aq18", Quantity = 1, Price = 1.00},
new Product { ProductId = 497, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-3.75", Cell = "aq19", Quantity = 1, Price = 1.00},
new Product { ProductId = 498, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-4.00", Cell = "aq20", Quantity = 1, Price = 1.00},
new Product { ProductId = 499, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-4.25", Cell = "aq21", Quantity = 1, Price = 1.00},
new Product { ProductId = 500, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-4.50", Cell = "aq22", Quantity = 1, Price = 1.00},
new Product { ProductId = 501, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-4.75", Cell = "aq23", Quantity = 1, Price = 1.00},
new Product { ProductId = 502, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-5.00", Cell = "aq24", Quantity = 1, Price = 1.00},
new Product { ProductId = 503, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-5.25", Cell = "aq25", Quantity = 1, Price = 1.00},
new Product { ProductId = 504, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-5.50", Cell = "aq26", Quantity = 1, Price = 1.00},
new Product { ProductId = 505, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-5.75", Cell = "aq27", Quantity = 1, Price = 1.00},
new Product { ProductId = 506, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-6.00", Cell = "aq28", Quantity = 1, Price = 1.00},
new Product { ProductId = 507, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-6.50", Cell = "aq29", Quantity = 1, Price = 1.00},
new Product { ProductId = 508, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-7.00", Cell = "aq30", Quantity = 1, Price = 1.00},
new Product { ProductId = 509, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-7.50", Cell = "aq31", Quantity = 1, Price = 1.00},
new Product { ProductId = 510, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-8.00", Cell = "aq32", Quantity = 1, Price = 1.00},
new Product { ProductId = 511, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-8.50", Cell = "aq33", Quantity = 1, Price = 1.00},
new Product { ProductId = 512, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-9.00", Cell = "aq34", Quantity = 1, Price = 1.00},
new Product { ProductId = 513, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-9.50", Cell = "aq35", Quantity = 1, Price = 1.00},
new Product { ProductId = 514, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-10.00", Cell = "aq36", Quantity = 1, Price = 1.00},
new Product { ProductId = 515, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-10.50", Cell = "aq37", Quantity = 1, Price = 1.00},
new Product { ProductId = 516, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-11.00", Cell = "aq38", Quantity = 1, Price = 1.00},
new Product { ProductId = 517, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-11.50", Cell = "aq39", Quantity = 1, Price = 1.00},
new Product { ProductId = 518, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "-12.00", Cell = "aq40", Quantity = 1, Price = 1.00},
new Product { ProductId = 519, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 520, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+0.25", Cell = "as5", Quantity = 1, Price = 1.00},
new Product { ProductId = 521, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+0.50", Cell = "as6", Quantity = 1, Price = 1.00},
new Product { ProductId = 522, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+0.75", Cell = "as7", Quantity = 1, Price = 1.00},
new Product { ProductId = 523, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+1.00", Cell = "as8", Quantity = 1, Price = 1.00},
new Product { ProductId = 524, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+1.25", Cell = "as9", Quantity = 1, Price = 1.00},
new Product { ProductId = 525, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+1.50", Cell = "as10", Quantity = 1, Price = 1.00},
new Product { ProductId = 526, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+1.75", Cell = "as11", Quantity = 1, Price = 1.00},
new Product { ProductId = 527, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+2.00", Cell = "as12", Quantity = 1, Price = 1.00},
new Product { ProductId = 528, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+2.25", Cell = "as13", Quantity = 1, Price = 1.00},
new Product { ProductId = 529, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+2.50", Cell = "as14", Quantity = 1, Price = 1.00},
new Product { ProductId = 530, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+2.75", Cell = "as15", Quantity = 1, Price = 1.00},
new Product { ProductId = 531, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+3.00", Cell = "as16", Quantity = 1, Price = 1.00},
new Product { ProductId = 532, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+3.25", Cell = "as17", Quantity = 1, Price = 1.00},
new Product { ProductId = 533, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+3.50", Cell = "as18", Quantity = 1, Price = 1.00},
new Product { ProductId = 534, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+3.75", Cell = "as19", Quantity = 1, Price = 1.00},
new Product { ProductId = 535, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+4.00", Cell = "as20", Quantity = 1, Price = 1.00},
new Product { ProductId = 536, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+4.25", Cell = "as21", Quantity = 1, Price = 1.00},
new Product { ProductId = 537, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+4.50", Cell = "as22", Quantity = 1, Price = 1.00},
new Product { ProductId = 538, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+4.75", Cell = "as23", Quantity = 1, Price = 1.00},
new Product { ProductId = 539, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+5.00", Cell = "as24", Quantity = 1, Price = 1.00},
new Product { ProductId = 540, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+5.25", Cell = "as25", Quantity = 1, Price = 1.00},
new Product { ProductId = 541, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+5.50", Cell = "as26", Quantity = 1, Price = 1.00},
new Product { ProductId = 542, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+5.75", Cell = "as27", Quantity = 1, Price = 1.00},
new Product { ProductId = 543, CategoryId = 1, Name = "ULTRA 6pk", BC = " 8.5", Sph = "+6.00", Cell = "as28", Quantity = 1, Price = 1.00},
new Product { ProductId = 544, CategoryId = 1, Name = "", BC = "", Sph = "", Cell = "", Quantity = 1, Price = 1.00},
new Product { ProductId = 545, CategoryId = 1, Name = "Раствор ReNu Multiplus 120 мл", BC = "", Sph = "", Cell = "e38", Quantity = 1, Price = 1.00},
new Product { ProductId = 546, CategoryId = 1, Name = "Раствор ReNu Multiplus 240 мл", BC = "", Sph = "", Cell = "e39", Quantity = 1, Price = 1.00},
new Product { ProductId = 547, CategoryId = 1, Name = "Раствор ReNu Multiplus 360 мл", BC = "", Sph = "", Cell = "e40", Quantity = 1, Price = 1.00},
new Product { ProductId = 548, CategoryId = 1, Name = "Раствор ReNu MPS 120", BC = "", Sph = "", Cell = "e41", Quantity = 1, Price = 1.00},
new Product { ProductId = 549, CategoryId = 1, Name = "Раствор ReNu MPS 240", BC = "", Sph = "", Cell = "e42", Quantity = 1, Price = 1.00},
new Product { ProductId = 550, CategoryId = 1, Name = "Раствор ReNu MPS 360", BC = "", Sph = "", Cell = "e43", Quantity = 1, Price = 1.00},
new Product { ProductId = 551, CategoryId = 1, Name = "Раствор BIOTRUE 120", BC = "", Sph = "", Cell = "e44", Quantity = 1, Price = 1.00},
new Product { ProductId = 552, CategoryId = 1, Name = "Раствор BIOTRUE 300", BC = "", Sph = "", Cell = "e45", Quantity = 1, Price = 1.00}
*/
                #endregion Product 1xx - 5xx
            });

            #region Add Customer
            var customers = new List<Customer>();

            customers.Add(new Customer() { CustomerId = 1, Name = "Иванов И.И.", Fullname = "Иванов И.И.", Company = "Оптика № 1", Email = "k1@gmail.com", Phone = "+375 29 123-12-12", Description = "Описание компании 1" });
            customers.Add(new Customer() { CustomerId = 2, Name = "Петров П.П.", Fullname = "Петров П.П.", Company = "Оптика Нова", Email = "k2@gmail.com", Phone = "+375 29 123-12-13", Description = "Описание компании 2"});
            customers.Add(new Customer() { CustomerId = 3, Name = "Смирнов С.С.", Fullname = "Смирнов С.С.", Company = "ИП Смирнов",  Email = "k3@gmail.com", Phone = "+375 29 123-12-14", Description = "Описание компании 3"});

            #region Add Random Customer
            for (int i = 4; i < limirRow; i++)
                customers.Add(new Customer()
                {
                    CustomerId = i,
                    Name = $"Покупатель: 10{i}",
                    Description = $"Customer c10{i}",
                    Fullname = $"Покупатель: 10{i}",
                    Company = $"Покупатель: 10{i}", 
                    Password = $"{i}",
                    Email = "k3@gmail.com",
                    Phone = "+375 29 123-12-14"
                });

            modelBuilder.Entity<Customer>().HasData(customers);
            #endregion Add Random Customer
            #endregion Add Customer

            #region Add OrderCustomer
            var randomOrderCustomer = new List<OrderCustomer>() {
                new OrderCustomer() { OrderCustomerId = 1, Description = "Описание oc201-c101",   Edited = DateTime.Now,  CustomerId = 1, ExcelFileId = 1 },
                new OrderCustomer() { OrderCustomerId = 2, Description = "Описание oc202-c102",   Edited = RandomDay(),   CustomerId = 2, ExcelFileId = 2 },
                new OrderCustomer() { OrderCustomerId = 3, Description = "Описание oc203-c103",   Edited = RandomDay(),   CustomerId = 3, ExcelFileId = 3 },
                new OrderCustomer() { OrderCustomerId = 4, Description = "Описание oc204-c101",   Edited = RandomDay(),   CustomerId = 1, ExcelFileId = 1 }
            };

            #region Add Random OrderCustomer
            for (int i = 5; i < limirRow; i++)
            {
                int randomCustomerId = random.Next(1, limirRow);
                randomOrderCustomer.Add(new OrderCustomer()
                {
                    OrderCustomerId = i,
                    Name = $"OrderVendor: 20{i}",
                    Description = $"Описание ov20{i}-c{randomCustomerId}",
                    Edited = RandomDay(),
                    CustomerId = randomCustomerId
                });
            }


            modelBuilder.Entity<OrderCustomer>().HasData(randomOrderCustomer);
            #endregion Add Random OrderCustomer
            #endregion Add OrderCustomer

            #region Add Vendor

            modelBuilder.Entity<Vendor>().HasData(new[]{
                new Vendor() { VendorId = 1, Name = "Поставщик № 501",   Description = "Описание p501", Company = "Поставщик № 501", Email = "mail-501@gmail.com" },
            });

            #region Add Random Vendor
            List<Vendor> randomVendors = new List<Vendor>();

            for (int i = 2; i < limirRow; i++)
                randomVendors.Add(new Vendor()
                {
                    VendorId = i,
                    Name = $"Поставщик: 50{i}",
                    Company = $"Поставщик: 50{i}",
                    Description = $"Описание p50{i}-{random.Next(1, limirRow)}",
                    Email = $"mail-50{i}@gmail.com"
                });

            modelBuilder.Entity<Vendor>().HasData(randomVendors);
            #endregion Add Random Vendor
            #endregion Add Vendor

            #region Add OrderVendor

            List<OrderVendor> orderVendors = new List<OrderVendor>();

            orderVendors.Add(
                new OrderVendor() { OrderVendorId = 1, Name = "OrderVendor-401", Description = "Описание ov401", Edited = DateTime.Now, VendorId = 1 }
            );

            #region Add Random OrderVendor


            for (int i = 2; i < limirRow; i++)
            {
                int randomVendorId = random.Next(1, limirRow);
                orderVendors.Add(new OrderVendor()
                {
                    OrderVendorId = i,
                    Name = $"OrderVendor: 40{i}",
                    Description = $"Описание 40{i}-{randomVendorId}",
                    Edited = RandomDay(),
                    VendorId = randomVendorId
                });
            }

            modelBuilder.Entity<OrderVendor>().HasData(orderVendors);
            #endregion Add Random OrderVendor
            #endregion Add OrderVendor

            #region Add ItemOrders
            List<ItemOrder> itemOrders = new List<ItemOrder>();

            itemOrders.AddRange( new List<ItemOrder>(){
                new ItemOrder() { ItemOrderId = 1, ProductId = 1, OrderCustomerId = 1, OrderVendorId = 1, Price = 1.11, Quantity = 22, Edited = DateTime.Now, Description = $"Опиасние oc201-io301-ov401 p1001" },
                #region
                new ItemOrder() { ItemOrderId = 2, ProductId = 2, OrderCustomerId = 1, OrderVendorId = 1, Price = 2.22, Quantity = 33,Edited = DateTime.Now, Description = $"Опиасние oc201-io302-ov401 p1002" },
                new ItemOrder() { ItemOrderId = 3, ProductId = 3, OrderCustomerId = 1, OrderVendorId = 1, Price = 3.33, Quantity = 44,Edited = DateTime.Now, Description = $"Опиасние oc201-io303-ov401 p1003" },
                new ItemOrder() { ItemOrderId = 4, ProductId = 4, OrderCustomerId = 1, OrderVendorId = 1, Price = 4.44, Quantity = 55,Edited = DateTime.Now, Description = $"Опиасние oc201-io304-ov401 p1004" },
                new ItemOrder() { ItemOrderId = 5, ProductId = 5, OrderCustomerId = 1, Price = 6.45, Quantity = 855, Edited = DateTime.Now, Description = $"Опиасние oc201-io305-ov403 p1005" },
                new ItemOrder() { ItemOrderId = 6, ProductId = 6, OrderCustomerId = 1, Edited = DateTime.Now, Description = $"Опиасние oc201-io306-ov404 p1006" }
                #endregion
             });

            #region Add Random ItemOrders


            for (int i = 7; i < limirRow; i++)
            {
                int randomProductId = random.Next(1, limirRow);
                int randomOrderCustomerId = random.Next(1, limirRow);
                int randomOrderVendorId = random.Next(1, limirRow);
                itemOrders.Add(new ItemOrder()
                {
                    ItemOrderId = i,
                    ProductId = randomProductId,
                    OrderCustomerId = randomOrderCustomerId,
                    OrderVendorId = randomOrderVendorId,
                    Description = $"Опиасние oc20{randomOrderCustomerId}-io30{i}-ov40{randomOrderVendorId} p100{randomProductId}",
                    Edited = RandomDay()
                });
            }

            modelBuilder.Entity<ItemOrder>().HasData(itemOrders);
            #endregion Add Random ItemOrders
            #endregion Add ItemOrders
        }

        
    }
}