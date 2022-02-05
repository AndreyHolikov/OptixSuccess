using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        //[Required]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Name { get; set; } = "Product";
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }


        public string BC { get; set; }
        public string Sph { get; set; }
        public string Cell { get; set; }

        //public int? ItemOrderId { get; set; }

        // navigation property for EF core
        
        public List<ItemOrder> ItemOrders { get; set; }
    }
}
