using System;
using System.Collections.Generic;

namespace BakeryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bakery app");

            var vegScroll = new VegemiteScroll() { Quantity = 10 };
            var muffin = new BlueberryMuffin() { Quantity = 14 };
            var croissant = new Croissant() { Quantity = 13 };
            var items = new List<Item>();
            
            items.Add(vegScroll);
            items.Add(muffin);
            items.Add(croissant);

            var calulatePacksService = new CalulatePacksService();
            var orderSummary = calulatePacksService.CalculatePacksAndCost(items);

            Console.WriteLine("Overall Cost: $" + orderSummary.OverallCost + "\n");

            foreach (var order in orderSummary.Orders)
            {
                Console.WriteLine(order.Item.Quantity + " " + order.Item.Code + " $" + order.Cost + "\n");
            }

        }
    }
}
