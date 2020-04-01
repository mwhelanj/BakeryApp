using System.Collections.Generic;

namespace BakeryApp
{
    public interface ICalulatePacksService
    {
        OrderSummary CalculatePacksAndCost(List<Item> Items);
    }
}