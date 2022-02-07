using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext dbContext;
        public CustomerRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
