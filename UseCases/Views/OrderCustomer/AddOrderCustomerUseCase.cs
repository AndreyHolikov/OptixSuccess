using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class AddOrderCustomerUseCase : IAddOrderCustomerUseCase
    {
        private readonly IOrderCustomerRepository orderCustomerRepository;

        public AddOrderCustomerUseCase(IOrderCustomerRepository orderCustomerRepository)
        {
            this.orderCustomerRepository = orderCustomerRepository;
        }

        public void Execute(OrderCustomer orderCustomer)
        {
            orderCustomerRepository.AddOrderCustomer(orderCustomer);
        }
    }
}
