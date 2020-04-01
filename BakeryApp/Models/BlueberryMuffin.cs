using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryApp
{
    public class BlueberryMuffin : Item
    {
        public BlueberryMuffin()
        {
            Code = ItemCode.MB11;
            Packs = new List<Pack>()
            {
                new Pack(){ Size = 8, Cost = 24.95, ItemCode =ItemCode.MB11},
                new Pack(){ Size = 5, Cost = 16.95, ItemCode =ItemCode.MB11},
                new Pack(){ Size = 2, Cost = 9.95, ItemCode =ItemCode.MB11}
            };
        }
    }
}
