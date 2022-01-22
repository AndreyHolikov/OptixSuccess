using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class OrderCustomer
    {
        public int OrderCustomerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Edited { get; set; }
        //        [Required]
        public int CustomerId { get; set; }
        //        [Required]
        public int ExcelFileId { get; set; }
    }
}
