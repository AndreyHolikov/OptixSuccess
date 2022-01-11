using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.InMemory
{
    public class CustomerInMemoryRepository
    {
        private List<Customer> customers;

        public CustomerInMemoryRepository()
        {
            // Add some  default customers

            customers = new List<Customer>()
            {
                new Customer() { СustomerId = 1, Name = "Customer-201", Description = "Customer-201.1"},
                new Customer() { СustomerId = 2, Name = "Customer-202", Description = "Customer-202.1"},
                new Customer() { СustomerId = 3, Name = "Customer-203", Description = "Customer-203.1"}
            };
        }

        public void AddCustomer(Customer customer)
        {
            if (customers.Any(x => x.Name.Equals(customer.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (customers != null && customers.Count > 0)
            {
                var maxId = customers.Max(x => x.СustomerId);
                customer.СustomerId = maxId + 1;

            }
            else
            {
                customer.СustomerId = 1;
            }
            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var customerToUpdate = GetCustomerById(customer.СustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = customer.Name;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            return customers?.Find(x => x.СustomerId == customerId);
            //return customers?.SingleOrDefault(x => x.CustomerId == customerId);
            //return customers?.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }

        public void DeleteCustomer(int customerId)
        {
            var cat = GetCustomerById(customerId);
            if (cat != null)
            {
                customers.Remove(cat);
            }
        }
    }
}
