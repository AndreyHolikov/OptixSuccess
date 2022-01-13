using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditOrderVendorUseCase : IEditOrderVendorUseCase
    {
        private readonly IOrderVendorRepository orderVendorRepository;

        public EditOrderVendorUseCase(IOrderVendorRepository orderVendorRepository)
        {
            this.orderVendorRepository = orderVendorRepository;
        }

        public void Execute(OrderVendor orderVendor)
        {
            orderVendorRepository.UpdateOrderVendor(orderVendor);
        }
    }
}
