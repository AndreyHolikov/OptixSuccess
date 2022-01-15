using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class ItemOrder
    {
        public int ItemOrderId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Edited { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderCustomerId { get; set; }
        [Required]
        public int OrderVendorId { get; set; }
    }
}
