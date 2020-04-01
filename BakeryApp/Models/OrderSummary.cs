using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryApp
{
    public class OrderSummary
    {
        public OrderSummary()
        {
            Orders = new List<Order>();
        }

        public decimal OverallCost
        {
            get { return (decimal)Orders.Sum(x => x.Cost); }
        }

        public List<Order> Orders { get; set; }
    }
}
