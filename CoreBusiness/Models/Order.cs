using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    public class Order
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Edited { get; set; }

        public List<ItemOrder> ItemOrders { get; set; }
    }
}
