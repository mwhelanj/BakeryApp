using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryApp
{
    public class Pack
    {
        public Pack() { }

        public Pack(Pack obj)
        {
            Size = obj.Size;
            Cost = obj.Cost;
            ItemCode = obj.ItemCode;
        }
        public int Size { get; set; }

        public double Cost { get; set; }

        public ItemCode ItemCode { get; set; }
    }
}
