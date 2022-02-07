using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewCustomersUseCase : IViewCustomersUseCase
    {
        private readonly ICustomerRepository customerRepository;

        public ViewCustomersUseCase(ICustomerRepository customerRepository) // View - Вид
        {
            this.customerRepository = customerRepository;
        }
        public IEnumerable<Customer> Execute() // Execute - Выполнять
        {
            return customerRepository.GetCustomers();
        }
    }
}
