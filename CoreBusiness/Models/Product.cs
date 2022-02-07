using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness.Models
{
    public class Product
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        //[Required]
        public int? CategoryId { get; set; }

        //[InverseProperty("Category")]
        [ForeignKey("CategoryId")]
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
