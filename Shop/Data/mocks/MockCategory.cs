using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.mocks
{
    public class MockCategory : IItemsCategory
    {
        public IEnumerable<Category> AllCategories 
        { 
            get 
            { 
                return new List<Category> 
                { 
                    new Category{ categoryName = "Сухофрукты" },
                    new Category{ categoryName = "Орехи" },
                    new Category{ categoryName = "Семечки и семена" },
                    new Category{ categoryName = "Специи и пряности" },
                    new Category{ categoryName = "Сушенные ягоды" },
                    new Category{ categoryName = "Цукаты" }
                };
            } 
        }
    }
}
