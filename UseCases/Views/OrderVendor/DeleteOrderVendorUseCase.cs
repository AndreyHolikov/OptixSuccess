using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteOrderVendorUseCase : IDeleteOrderVendorUseCase
    {
        private readonly IOrderVendorRepository orderVendorRepository;

        public DeleteOrderVendorUseCase(IOrderVendorRepository orderVendorRepository)
        {
            this.orderVendorRepository = orderVendorRepository;
        }

        public void Delete(int orderVendorId)
        {
            orderVendorRepository.DeleteOrderVendor(orderVendorId);
        }
    }
}
