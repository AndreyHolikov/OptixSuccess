using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IItemOrderRepository
    {
        public IEnumerable<ItemOrder> GetItemOrders();
        public IEnumerable<ItemOrder> GetItemOrdersByOrderCustomerId(int orderCustomerId);
        public IEnumerable<ItemOrder> GetItemOrdersByOrderVendorId(int orderVendorId);
        public void AddItemOrder(ItemOrder itemOrder);
        public void UpdateItemOrder(ItemOrder itemOrder);
        public ItemOrder GetItemOrderById(int itemOrderId);
        public void DeleteItemOrder(int itemOrderId);
    }
}
