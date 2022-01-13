using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteOrderCustomerUseCase : IDeleteOrderCustomerUseCase
    {
        private readonly IOrderCustomerRepository orderCustomerRepository;

        public DeleteOrderCustomerUseCase(IOrderCustomerRepository orderCustomerRepository)
        {
            this.orderCustomerRepository = orderCustomerRepository;
        }

        public void Delete(int orderCustomerId)
        {
            orderCustomerRepository.DeleteOrderCustomer(orderCustomerId);
        }
    }
}
