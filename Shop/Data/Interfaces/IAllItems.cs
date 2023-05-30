using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IAllItems
    {
        IEnumerable<Item> Items { get; }

        IEnumerable<Item> getFavItems { get; }

        Item getObjectItem(int itemID);
    }
}
