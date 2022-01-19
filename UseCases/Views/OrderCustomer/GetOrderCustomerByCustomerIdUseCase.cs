using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetOrderCustomerByCustomerIdUseCase : IGetOrderCustomerByCustomerIdUseCase
    {
        private readonly IOrderCustomerRepository orderCustomerRepository;

        public GetOrderCustomerByCustomerIdUseCase(IOrderCustomerRepository orderCustomerRepository)
        {
            this.orderCustomerRepository = orderCustomerRepository;
        }

        public IEnumerable<OrderCustomer> Execute(int customerId)
        {
            return orderCustomerRepository.GetOrderCustomerByCustomerId(customerId);
        }
    }
}
