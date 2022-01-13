using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewVendorsUseCase : IViewVendorsUseCase
    {
        private readonly IVendorRepository vendorRepository;

        public ViewVendorsUseCase(IVendorRepository vendorRepository) // View - Вид
        {
            this.vendorRepository = vendorRepository;
        }
        public IEnumerable<Vendor> Execute() // Execute - Выполнять
        {
            return vendorRepository.GetVendors();
        }
    }
}
