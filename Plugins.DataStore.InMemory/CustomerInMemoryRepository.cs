using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        private List<Customer> customers;

        public CustomerInMemoryRepository()
        {
            // Add some  default customers

            customers = new List<Customer>()
            {
                new Customer() { СustomerId = 1, Name = "Иванов И.И.",  Fullname = "Иванов И.И.",  Company = "Оптика № 1",  Email = "k1@gmail.com", Phone = "+375 29 123-12-12", Description = "Описание компании 1"},
                new Customer() { СustomerId = 2, Name = "Петров П.П.",  Fullname = "Петров П.П.",  Company = "Оптика Нова", Email = "k2@gmail.com", Phone = "+375 29 123-12-13", Description = "Описание компании 2"},
                new Customer() { СustomerId = 3, Name = "Смирнов С.С.", Fullname = "Смирнов С.С.", Company = "ИП Смирнов",  Email = "k3@gmail.com", Phone = "+375 29 123-12-14", Description = "Описание компании 3"}
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
