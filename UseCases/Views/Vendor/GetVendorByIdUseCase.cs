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
    public class GetVendorByIdUseCase : IGetVendorByIdUseCase // Vendor
    {
        private readonly IVendorRepository vendorRepository;

        public GetVendorByIdUseCase(IVendorRepository vendorRepository)
        {
            this.vendorRepository = vendorRepository;
        }
        public Vendor Execute(int vendorId)
        {
            return vendorRepository.GetVendorById(vendorId);
        }
    }
}
