using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    [Table("ItemOrders")]
    public class ItemOrder
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemOrderId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Edited { get; set; }


        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int OrderCustomerId { get; set; }
        public OrderCustomer OrderCustomer { get; set; }

        public int? OrderVendorId { get; set; }
        public OrderVendor OrderVendor { get; set; }
    }
}
