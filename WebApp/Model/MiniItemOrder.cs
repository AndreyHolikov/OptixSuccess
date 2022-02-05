using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class MiniItemOrder //record
    {
        #region public field
        public List<int> selectedItemOrderIds { get; set; } = new List<int>();
        public int OrderVendorId { get; set; }
        #endregion

        public MiniItemOrder(int orderVendorId = 1) => OrderVendorId = orderVendorId;
    }
}
