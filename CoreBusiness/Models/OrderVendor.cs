 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    public class OrderVendor : Order
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderVendorId { get; set; }
        [Required]
        public int VendorId { get; set; }

        //[InverseProperty("Vendor")]
        [ForeignKey("VendorId")]
        public virtual Vendor Vendor { get; set; }

        //public ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
