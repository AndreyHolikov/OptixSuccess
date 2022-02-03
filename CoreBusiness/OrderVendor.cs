﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class OrderVendor : Order
    {
        public int OrderVendorId { get; set; }
        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }
    }
}
