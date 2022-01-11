﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.InMemory
{
    public class OrderVendorInMemoryRepository
    {
        private List<OrderVendor> orderVendors;

        public OrderVendorInMemoryRepository()
        {
            // Add some  default orderVendors

            orderVendors = new List<OrderVendor>()
            {
                new OrderVendor() { OrderVendorId = 1, Name = "OrderVendor-401", Description = "Customer-401.1"},
                new OrderVendor() { OrderVendorId = 2, Name = "OrderVendor-402", Description = "Customer-402.1"},
                new OrderVendor() { OrderVendorId = 3, Name = "OrderVendor-403", Description = "Customer-403.1"}
            };
        }

        public void AddOrderVendor(OrderVendor orderVendor)
        {
            if (orderVendors.Any(x => x.Name.Equals(orderVendor.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (orderVendors != null && orderVendors.Count > 0)
            {
                var maxId = orderVendors.Max(x => x.OrderVendorId);
                orderVendor.OrderVendorId = maxId + 1;

            }
            else
            {
                orderVendor.OrderVendorId = 1;
            }
            orderVendors.Add(orderVendor);
        }

        public void UpdateOrderVendor(OrderVendor orderVendor)
        {
            var orderVendorToUpdate = GetOrderVendorById(orderVendor.OrderVendorId);
            if (orderVendorToUpdate != null)
            {
                orderVendorToUpdate.Name = orderVendor.Name;
            }
        }

        public OrderVendor GetOrderVendorById(int orderVendorId)
        {
            return orderVendors?.Find(x => x.OrderVendorId == orderVendorId);
            //return orderVendors?.SingleOrDefault(x => x.OrderVendorId == orderVendorId);
            //return orderVendors?.FirstOrDefault(x => x.OrderVendorId == orderVendorId);
        }

        public IEnumerable<OrderVendor> GetCategories()
        {
            return orderVendors;
        }

        public void DeleteOrderVendor(int orderVendorId)
        {
            var cat = GetOrderVendorById(orderVendorId);
            if (cat != null)
            {
                orderVendors.Remove(cat);
            }
        }
    }
}
