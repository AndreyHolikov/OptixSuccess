using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IOrderVendorRepository
    {
        public IEnumerable<OrderVendor> GetCategories();
        public void AddOrderVendor(OrderVendor orderVendor);
        public void UpdateOrderVendor(OrderVendor orderVendor);
        public OrderVendor GetOrderVendorById(int orderVendorId);
        public void DeleteOrderVendor(int orderVendorId);
    }
}
