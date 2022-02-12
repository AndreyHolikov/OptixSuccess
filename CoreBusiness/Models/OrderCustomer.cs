using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    public class OrderCustomer : Order
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderCustomerId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int? ExcelFileId { get; set; }
    }
}
