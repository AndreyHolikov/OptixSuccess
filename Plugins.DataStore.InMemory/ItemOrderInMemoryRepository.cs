using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ItemOrderInMemoryRepository : IItemOrderRepository
    {
        private List<ItemOrder> itemOrders;

        public ItemOrderInMemoryRepository()
        {
            // Add some  default itemOrders

            itemOrders = new List<ItemOrder>()
            {
                new ItemOrder() { 
                    ItemOrderId = 1, 
                    ProductId = 1, 
                    OrderCustomerId = 1, 
                    OrderVendorId = 1, 
                    Price = 1.11, 
                    Quantity = 22,
                    Edited = DateTime.Now
                },
                new ItemOrder() { 
                    ItemOrderId = 2, 
                    ProductId = 1, 
                    OrderCustomerId = 1, 
                    OrderVendorId = 2, 
                    Price = 2.22, 
                    Quantity = 33,
                    Edited = DateTime.Now
                },
                new ItemOrder() { 
                    ItemOrderId = 3, 
                    ProductId = 1, 
                    OrderCustomerId = 2, 
                    OrderVendorId = 1, 
                    Price = 3.33, 
                    Quantity = 44,
                    Edited = DateTime.Now
                },
                new ItemOrder() { 
                    ItemOrderId = 3, 
                    ProductId = 1, 
                    OrderCustomerId = 3, 
                    OrderVendorId = 3, 
                    Price = 4.44,
                    Quantity = 55,
                    Edited = DateTime.Now
                }
            };
        }

        public void AddItemOrder(ItemOrder itemOrder)
        {
            //if (itemOrders.Any(x => x.Name.Equals(itemOrder.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (itemOrders != null && itemOrders.Count > 0)
            {
                var maxId = itemOrders.Max(x => x.ItemOrderId);
                itemOrder.ItemOrderId = maxId + 1;
            }
            else
            {
                itemOrder.ItemOrderId = 1;
            }
            itemOrder.Edited = DateTime.Now;
            itemOrders.Add(itemOrder);
        }

        public void UpdateItemOrder(ItemOrder itemOrder)
        {
            var itemOrderToUpdate = GetItemOrderById(itemOrder.ItemOrderId);
            if (itemOrderToUpdate != null)
            {
                itemOrderToUpdate.ProductId = itemOrder.ProductId;
                itemOrderToUpdate.OrderCustomerId = itemOrder.OrderCustomerId;
                itemOrderToUpdate.OrderVendorId = itemOrder.OrderVendorId;
                itemOrderToUpdate.Description = itemOrder.Description;
                itemOrderToUpdate.Price = itemOrder.Price;
                itemOrderToUpdate.Quantity = itemOrder.Quantity;
                itemOrderToUpdate.Edited = DateTime.Now;
            }
        }

        public ItemOrder GetItemOrderById(int itemOrderId)
        {
            return itemOrders?.Find(x => x.ItemOrderId == itemOrderId);
            //return itemOrders?.SingleOrDefault(x => x.ItemOrderId == itemOrderId);
            //return itemOrders?.FirstOrDefault(x => x.ItemOrderId == itemOrderId);
        }

        public IEnumerable<ItemOrder> GetItemOrders()
        {
            return itemOrders;
        }

        public void DeleteItemOrder(int itemOrderId)
        {
            var cat = GetItemOrderById(itemOrderId);
            if (cat != null)
            {
                itemOrders.Remove(cat);
            }
        }
    }
}
