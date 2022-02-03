using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Edited { get; set; }

        public List<ItemOrder> ItemOrders { get; set; }
    }
}
