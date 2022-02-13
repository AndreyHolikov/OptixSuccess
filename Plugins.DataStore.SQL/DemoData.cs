using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.SQL
{
    public class DemoData
    {
        private List<Product> Products;
        public int limirRow { get; set; }

        public DemoData(List<Product> products, int limirRow = 10)
        {
            this.Products = products;
            this.limirRow = limirRow;
        }

        private readonly Random random = new();
        private DateTime RandomDay()
        {
            DateTime start = new(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new();

            customers.Add(new Customer() { CustomerId = 1, Name = "Иванов И.И.", Fullname = "Иванов И.И.", Company = "Оптика № 1", Email = "k1@gmail.com", Phone = "+375 29 123-12-12", Description = "Описание компании 1" });
            customers.Add(new Customer() { CustomerId = 2, Name = "Петров П.П.", Fullname = "Петров П.П.", Company = "Оптика Нова", Email = "k2@gmail.com", Phone = "+375 29 123-12-13", Description = "Описание компании 2" });
            customers.Add(new Customer() { CustomerId = 3, Name = "Смирнов С.С.", Fullname = "Смирнов С.С.", Company = "ИП Смирнов", Email = "k3@gmail.com", Phone = "+375 29 123-12-14", Description = "Описание компании 3" });

            #region Add Random Customer
            for (int i = 4; i < limirRow; i++)
            {
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
            }
            return customers;
            #endregion Add Random Customer

        }

        public List<OrderCustomer> GetOrderCustomers()
        {
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
            #endregion Add Random OrderCustomer
            return randomOrderCustomer; 
        }
        public List<Vendor> GetVendors()
        {
            #region Add Random Vendor
            List<Vendor> randomVendors = new();
            randomVendors.Add(new Vendor() { VendorId = 1, Name = "Поставщик № 501", Description = "Описание p501", Company = "Поставщик № 501", Email = "mail-501@gmail.com" });

            for (int i = 2; i < limirRow; i++)
                randomVendors.Add(new Vendor()
                {
                    VendorId = i,
                    Name = $"Поставщик: 50{i}",
                    Company = $"Поставщик: 50{i}",
                    Description = $"Описание p50{i}-{random.Next(1, limirRow)}",
                    Email = $"mail-50{i}@gmail.com",
                    Phone = "+375 29 123-12-14"
                });
            #endregion Add Random Vendor
            return randomVendors;   
        }
        public List<OrderVendor> GetOrderVendors()
        {
            List<OrderVendor> orderVendors = new();

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
            #endregion Add Random OrderVendor
            return orderVendors;    
        }

        public List<ItemOrder> GetItemOrders()
        {
            List<ItemOrder> itemOrders = new();

            itemOrders.AddRange(new List<ItemOrder>(){
                new ItemOrder() { ItemOrderId = 1, ProductId = 1, OrderCustomerId = 1, OrderVendorId = 1, Price = 1.11, Quantity = 22, Edited = DateTime.Now, Description = $"Опиасние oc201-io301-ov401 p1001" },
                #region
                new ItemOrder() { ItemOrderId = 2, ProductId = 2, OrderCustomerId = 1, OrderVendorId = 1, Price = 2.22, Quantity = 33,Edited = DateTime.Now, Description = $"Опиасние oc201-io302-ov401 p1002" },
                new ItemOrder() { ItemOrderId = 3, ProductId = 3, OrderCustomerId = 1, OrderVendorId = 1, Price = 3.33, Quantity = 44,Edited = DateTime.Now, Description = $"Опиасние oc201-io303-ov401 p1003" },
                new ItemOrder() { ItemOrderId = 4, ProductId = 4, OrderCustomerId = 1, OrderVendorId = 1, Price = 4.44, Quantity = 55,Edited = DateTime.Now, Description = $"Опиасние oc201-io304-ov401 p1004" },
                new ItemOrder() { ItemOrderId = 5, ProductId = 5, OrderCustomerId = 1, Price = 6.45, Quantity = 855, Edited = DateTime.Now, Description = $"Опиасние oc201-io305-ov403 p1005" },
                new ItemOrder() { ItemOrderId = 6, ProductId = 6, OrderCustomerId = 1, Edited = DateTime.Now, Description = $"Опиасние oc201-io306-ov404 p1006" }
                #endregion
             });

            for (int i = 7; i < 20; i++)
            {
                int randomProductId = random.Next(2, 500);
                randomProductId = (Products.Find(x => x.ProductId == randomProductId) == null) ? randomProductId + 1 : randomProductId;

                int randomOrderCustomerId = random.Next(1, 10);
                int randomOrderVendorId = random.Next(1, 10);
                int randomQuantity = random.Next(1, 10);
                itemOrders.Add(new ItemOrder()
                {
                    ItemOrderId = i,
                    ProductId = randomProductId,
                    OrderCustomerId = randomOrderCustomerId,
                    OrderVendorId = randomOrderVendorId,
                    Description = $"Опиасние oc20{randomOrderCustomerId}-io30{i}-ov40{randomOrderVendorId} p100{randomProductId}",
                    Edited = RandomDay(),
                    Quantity = randomQuantity
                });
            }

            #region Add Random ItemOrders
            int ItemOrderNewLimirRow = limirRow * 20;
            for (int i = 21; i < ItemOrderNewLimirRow; i++)
            {
                int randomProductId = random.Next(2, 500);
                randomProductId = (Products.Find(x => x.ProductId == randomProductId) == null) ? randomProductId + 1 : randomProductId;

                int randomOrderCustomerId = random.Next(1, limirRow);
                int randomOrderVendorId = random.Next(1, limirRow);
                int randomQuantity = random.Next(100, 500);
                itemOrders.Add(new ItemOrder()
                {
                    ItemOrderId = i,
                    ProductId = randomProductId,
                    OrderCustomerId = randomOrderCustomerId,
                    OrderVendorId = randomOrderVendorId,
                    Description = $"Опиасние oc20{randomOrderCustomerId}-io30{i}-ov40{randomOrderVendorId} p100{randomProductId}",
                    Edited = RandomDay(),
                    Quantity = randomQuantity
                });
            }
            #endregion Add Random ItemOrders
            return itemOrders;              
        }
    }
}