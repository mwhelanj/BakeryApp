using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryApp
{
    public class Order
    {
        public Order()
        {
            Packs = new List<Pack>();
        }

        public decimal Cost
        {
            get
            {
                if (Packs.Count == 0)
                    return 0;
                else
                    return (decimal)Packs.Sum(x => x.Cost);
            }
        }

        public List<Pack> Packs { get; set; }

        public Item Item { get; set; }
    }
}
