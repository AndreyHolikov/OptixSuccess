using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteCustomerUseCase : IDeleteCustomerUseCase
    {
        private readonly ICustomerRepository customerRepository;

        public DeleteCustomerUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void Delete(int customerId)
        {
            customerRepository.DeleteCustomer(customerId);
        }
    }
}
