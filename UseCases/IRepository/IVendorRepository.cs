using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IVendorRepository
    {
        public IEnumerable<Vendor> GetVendors();
        public void AddVendor(Vendor vendor);
        public void UpdateVendor(Vendor vendor);
        public Vendor GetVendorById(int vendorId);
        public void DeleteVendor(int vendorId);
    }
}
