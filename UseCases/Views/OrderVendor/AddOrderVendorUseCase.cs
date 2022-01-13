using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class AddOrderVendorUseCase : IAddOrderVendorUseCase
    {
        private readonly IOrderVendorRepository orderVendorRepository;

        public AddOrderVendorUseCase(IOrderVendorRepository orderVendorRepository)
        {
            this.orderVendorRepository = orderVendorRepository;
        }

        public void Excecute(OrderVendor orderVendor)
        {
            orderVendorRepository.AddOrderVendor(orderVendor);
        }
    }
}
