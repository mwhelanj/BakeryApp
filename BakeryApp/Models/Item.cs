using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryApp
{
    public abstract class Item
    {
        public ItemCode Code { get; set; }

        public int Quantity { get; set; }

        public List<Pack> Packs { get; set; }
    }
}
