using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryApp
{
    public class CalulatePacksService : ICalulatePacksService
    {
        /// <summary>
        /// Will calculate the number of packs and total cost of all items
        /// </summary>
        /// <param name="Items"></param>
        /// <returns>Summary of the order</returns>
        public OrderSummary CalculatePacksAndCost(List<Item> Items)
        {
            var orderSummary = new OrderSummary();
            foreach (var item in Items)
            {
                var order = new Order();
                var i = 0;
                order.Item =item;
                var packs = item.Packs.OrderByDescending(x => x.Size).ToList();
                orderSummary.Orders.Add(calculateOrder(item.Quantity, packs, packs.FirstOrDefault(), i, order));
            }
            return orderSummary;
        }

        // calculate best number of packs and cost
        private Order calculateOrder(int quantity, List<Pack> packs, Pack pack, int i, Order order)
        {
            var size = pack.Size;
            var remainder = quantity % size;
            var division = quantity / size;
            if (remainder == 0) // all packs selected successfully
            {
                AddMultiplePacks(division, pack, order);
                return order;
            }
            if(packs.Count()== 1) // left over values from packs
            {
                return order;
            }
            if (packs.Count() == (i + 1)) // end of list- try with a different pack
            {
                return TryWithDifferentPacks(packs, order);
            }
            if (remainder < size)
            {
                i++; 
                if (order.Packs.Count == 0) // add packs if empty 
                {
                    AddMultiplePacks(division, pack, order);
                    return calculateOrder(remainder, packs, packs.ElementAt(i), i, order);
                }
                // move to next pack
                return calculateOrder(quantity, packs, packs.ElementAt(i), i, order);
            }
            return order;
        }

        // Start order fresh with different packs
        private Order TryWithDifferentPacks(List<Pack> packs, Order order)
        {
            var newOrder = new Order();
            newOrder.Item = order.Item;
            var newList = packs.Skip(1).ToList().ConvertAll(x => new Pack(x));
            return calculateOrder(order.Item.Quantity, newList, newList.FirstOrDefault(), 0, newOrder);
        }

        // add multiple pack of the same type
        private void AddMultiplePacks(int count, Pack pack, Order order)
        {
            while (count != 0)
            {
                order.Packs.Add(pack);
                count--;
            }
        }
    }
}
