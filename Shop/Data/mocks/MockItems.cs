using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.mocks
{
    public class MockItems : IAllItems
    {

        private readonly IItemsCategory _categoryItems = new MockCategory();

        public IEnumerable<Item> Items 
        {
            get
            {
                return new List<Item>()
                {
                    new Item 
                    { 
                        name = "Ананас", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "", 
                        price = 500, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryItems.AllCategories.ElementAt(0)
                    }
                };
            } 
        }
        public IEnumerable<Item> getFavItems { get; set; }

        public Item getObjectItem(int itemID)
        {
            throw new System.NotImplementedException();
        }
    }
}
