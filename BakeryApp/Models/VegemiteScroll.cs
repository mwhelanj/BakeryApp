using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryApp
{
    public class VegemiteScroll : Item
    {
        public VegemiteScroll()
        {
            Code = ItemCode.VS5;
            Packs = new List<Pack>()
            {
                new Pack(){ Size = 5, Cost = 8.99, ItemCode =ItemCode.VS5},
                new Pack(){ Size = 3, Cost = 6.99, ItemCode =ItemCode.VS5}
            };
        }
    }
}
