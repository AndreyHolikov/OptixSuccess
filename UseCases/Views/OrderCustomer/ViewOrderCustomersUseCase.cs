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
    public class ViewOrderCustomersUseCase : IViewOrderCustomersUseCase
    {
        private readonly IOrderCustomerRepository orderCustomerRepository;

        public ViewOrderCustomersUseCase(IOrderCustomerRepository orderCustomerRepository) // View - Вид
        {
            this.orderCustomerRepository = orderCustomerRepository;
        }
        public IEnumerable<OrderCustomer> Execute() // Execute - Выполнять
        {
            return orderCustomerRepository.GetOrderCustomers();
        }
    }
}
