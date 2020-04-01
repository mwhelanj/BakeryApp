using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryApp
{
    public class Croissant : Item
    {
        public Croissant()
        {
            Code = ItemCode.CF;
            Packs = new List<Pack>()
            {
                new Pack(){ Size = 9, Cost = 16.99, ItemCode =ItemCode.CF},
                new Pack(){ Size = 5, Cost = 9.95, ItemCode =ItemCode.CF},
                new Pack(){ Size = 3, Cost = 5.95, ItemCode =ItemCode.CF}
            };
        }
    }
}
