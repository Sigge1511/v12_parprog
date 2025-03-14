using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v12_parprog
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        virtual public List<Order> Orders { get; set; }

    }
}
