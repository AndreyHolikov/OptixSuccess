using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetOrderCustomerByIdUseCase : IGetOrderCustomerByIdUseCase
    {
        private readonly IOrderCustomerRepository orderCustomerRepository;

        public GetOrderCustomerByIdUseCase(IOrderCustomerRepository orderCustomerRepository)
        {
            this.orderCustomerRepository = orderCustomerRepository;
        }
        public OrderCustomer Excecute(int orderCustomerId)
        {
            return orderCustomerRepository.GetOrderCustomerById(orderCustomerId);
        }
    }
}
