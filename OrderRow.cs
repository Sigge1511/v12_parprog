using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v12_parprog
{
    internal class OrderRow
    {
        
        public int OrderRowId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double RowPrice { get; set; }


    }
}
