using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteVendorUseCase : IDeleteVendorUseCase
    {
        private readonly IVendorRepository vendorRepository;

        public DeleteVendorUseCase(IVendorRepository vendorRepository)
        {
            this.vendorRepository = vendorRepository;
        }

        public void Delete(int vendorId)
        {
            vendorRepository.DeleteVendor(vendorId);
        }
    }
}
