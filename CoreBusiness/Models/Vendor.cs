using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    public class Vendor
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }

        public List<OrderVendor> OrderVendors { get; set; }
    }
}
