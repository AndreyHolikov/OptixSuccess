using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
