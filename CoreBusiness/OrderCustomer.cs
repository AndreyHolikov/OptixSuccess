using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class OrderCustomer : Order
    {
        public int OrderCustomerId { get; set; }
        public int CustomerId { get; set; }
        public int ExcelFileId { get; set; }
        public Customer Customer { get; set; }
    }
}
