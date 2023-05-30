using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Item.Any())
            {
                content.AddRange(
                    new Item
                    {
                        name = "Ананас",
                        shortDesc = "",
                        longDesc = "",
                        img = "",
                        price = 500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Сухофрукты"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Сухофрукты" },
                        new Category{ categoryName = "Орехи" },
                        new Category{ categoryName = "Семечки и семена" },
                        new Category{ categoryName = "Специи и пряности" },
                        new Category{ categoryName = "Сушенные ягоды" },
                        new Category{ categoryName = "Цукаты" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category elem in list) 
                        category.Add(elem.categoryName, elem);
                }
                return category;
            }
        }
    }
}
