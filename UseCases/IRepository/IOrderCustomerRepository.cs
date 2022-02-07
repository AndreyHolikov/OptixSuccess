using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IOrderCustomerRepository
    {
        public IEnumerable<OrderCustomer> GetOrderCustomers();
        public IEnumerable<OrderCustomer> GetOrderCustomerByCustomerId(int customerId);
        public void AddOrderCustomer(OrderCustomer orderCustomer);
        public void UpdateOrderCustomer(OrderCustomer orderCustomer);
        public OrderCustomer GetOrderCustomerById(int orderCustomerId);
        public void DeleteOrderCustomer(int orderCustomerId);
    }
}
