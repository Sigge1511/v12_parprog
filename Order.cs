﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v12_parprog
{
    internal class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        virtual public List<OrderRow> OrderRows { get; set; }
        public double TotalPrice { get; set; }


    }
}
