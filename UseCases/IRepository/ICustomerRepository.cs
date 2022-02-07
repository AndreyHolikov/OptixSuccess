using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomers();
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public Customer GetCustomerById(int customerId);
        public void DeleteCustomer(int customerId);
    }
}
