using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Reporsitory
{
    public class ItemRepository : IAllItems
    {
        private readonly AppDBContent appDBContent;

        public ItemRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Item> Items => appDBContent.Item.Include(c => c.Category);

        public IEnumerable<Item> getFavItems => appDBContent.Item.Where(P => P.isFavourite).Include(c => c.Category);

        public Item getObjectItem(int itemID) => appDBContent.Item.FirstOrDefault(p => p.id == itemID);
    }
}
