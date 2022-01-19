using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class OrderCustomerInMemoryRepository : IOrderCustomerRepository
    {
        private List<OrderCustomer> orderCustomers;

        public OrderCustomerInMemoryRepository()
        {
            // Add some  default orderCustomers

            orderCustomers = new List<OrderCustomer>()
            {
                new OrderCustomer() { 
                    OrderCustomerId = 1, 
                    Name = "OrderCustomer-301", 
                    Description = "OrderCustomer-301.1",
                    Edited = DateTime.Now,
                    CustomerId = 1,
                    ExcelFileId = 1
        },
                new OrderCustomer() { 
                    OrderCustomerId = 2, 
                    Name = "OrderCustomer-302", 
                    Description = "OrderCustomer-302.1",
                    Edited = DateTime.Now,
                    CustomerId = 2,
                    ExcelFileId = 2
                },
                new OrderCustomer() { 
                    OrderCustomerId = 3, 
                    Name = "OrderCustomer-303", 
                    Description = "OrderCustomer-303.1",
                    Edited = DateTime.Now,
                    CustomerId = 3,
                    ExcelFileId = 3
                }
            };
        }

        public void AddOrderCustomer(OrderCustomer orderCustomer)
        {
            if (orderCustomers.Any(x => x.Name.Equals(orderCustomer.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (orderCustomers != null && orderCustomers.Count > 0)
            {
                var maxId = orderCustomers.Max(x => x.OrderCustomerId);
                orderCustomer.OrderCustomerId = maxId + 1;
            }
            else
            {
                orderCustomer.OrderCustomerId = 1;
            }
            orderCustomer.Edited = DateTime.Now;
            orderCustomers.Add(orderCustomer);
        }

        public void UpdateOrderCustomer(OrderCustomer orderCustomer)
        {
            var orderCustomerToUpdate = GetOrderCustomerById(orderCustomer.OrderCustomerId);
            if (orderCustomerToUpdate != null)
            {
                orderCustomerToUpdate.Name = orderCustomer.Name;
                orderCustomer.Edited = DateTime.Now;
            }
        }

        public OrderCustomer GetOrderCustomerById(int orderCustomerId)
        {
            return orderCustomers?.Find(x => x.OrderCustomerId == orderCustomerId);
            //return orderCustomers?.SingleOrDefault(x => x.OrderCustomerId == orderCustomerId);
            //return orderCustomers?.FirstOrDefault(x => x.OrderCustomerId == orderCustomerId);
        }

        public IEnumerable<OrderCustomer> GetOrderCustomers()
        {
            return orderCustomers;
        }

        public void DeleteOrderCustomer(int orderCustomerId)
        {
            var cat = GetOrderCustomerById(orderCustomerId);
            if (cat != null)
            {
                orderCustomers.Remove(cat);
            }
        }

        public IEnumerable<OrderCustomer> GetOrderCustomerByCustomerId(int customerId)
        {
            return orderCustomers.Where<OrderCustomer>(x => x.CustomerId == customerId);
        }
    }
}
