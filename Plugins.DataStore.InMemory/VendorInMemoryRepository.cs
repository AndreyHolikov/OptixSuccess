﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class VendorInMemoryRepository : IVendorRepository
    {
        private List<Vendor> vendors;

        public VendorInMemoryRepository()
        {
            // Add some  default vendors

            vendors = new List<Vendor>()
            {
                new Vendor() { VendorId = 1, Name = "Vendor-501", Description = "Customer-501.1"},
                new Vendor() { VendorId = 2, Name = "Vendor-502", Description = "Customer-502.1"},
                new Vendor() { VendorId = 3, Name = "Vendor-503", Description = "Customer-503.1"}
            };
        }

        public void AddVendor(Vendor vendor)
        {
            if (vendors.Any(x => x.Name.Equals(vendor.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (vendors != null && vendors.Count > 0)
            {
                var maxId = vendors.Max(x => x.VendorId);
                vendor.VendorId = maxId + 1;

            }
            else
            {
                vendor.VendorId = 1;
            }
            vendors.Add(vendor);
        }

        public void UpdateVendor(Vendor vendor)
        {
            var vendorToUpdate = GetVendorById(vendor.VendorId);
            if (vendorToUpdate != null)
            {
                vendorToUpdate.Name = vendor.Name;
            }
        }

        public Vendor GetVendorById(int vendorId)
        {
            return vendors?.Find(x => x.VendorId == vendorId);
            //return vendors?.SingleOrDefault(x => x.VendorId == vendorId);
            //return vendors?.FirstOrDefault(x => x.VendorId == vendorId);
        }

        public IEnumerable<Vendor> GetVendors()
        {
            return vendors;
        }

        public void DeleteVendor(int vendorId)
        {
            var cat = GetVendorById(vendorId);
            if (cat != null)
            {
                vendors.Remove(cat);
            }
        }
    }
}
