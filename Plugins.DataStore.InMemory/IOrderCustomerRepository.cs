using CoreBusiness;
using System.Collections.Generic;

namespace Plugins.DataStore.InMemory
{
    public interface IOrderCustomerRepository
    {
        void AddOrderCustomer(OrderCustomer orderCustomer);
        void DeleteOrderCustomer(int orderCustomerId);
        IEnumerable<OrderCustomer> GetCategories();
        OrderCustomer GetOrderCustomerById(int orderCustomerId);
        void UpdateOrderCustomer(OrderCustomer orderCustomer);
    }
}