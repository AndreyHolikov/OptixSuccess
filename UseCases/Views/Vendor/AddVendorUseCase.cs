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
    public class AddVendorUseCase : IAddVendorUseCase // Vendor
    {
        private readonly IVendorRepository vendorRepository;

        public AddVendorUseCase(IVendorRepository vendorRepository)
        {
            this.vendorRepository = vendorRepository;
        }

        public void Execute(Vendor vendor)
        {
            vendorRepository.AddVendor(vendor);
        }
    }
}
