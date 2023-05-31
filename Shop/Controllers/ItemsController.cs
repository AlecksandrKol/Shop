using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Controllers
{
    public class ItemsController : Controller
    {

        private readonly IAllItems _allItems;
        private readonly IItemsCategory _allCategories;

        public ItemsController(IAllItems allItems, IItemsCategory allCategories)
        {
            _allItems = allItems;
            _allCategories = allCategories;
        }

        [Route("Items/List")]
        [Route("Items/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Item> items = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
                items = _allItems.Items.OrderBy(x => x.id);
            else
            {
                if (string.Equals("Cyxofruts", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Сухофрукты")).OrderBy(i => i.id);
                    currCategory = "Сухофрукты";
                } 
                else if(string.Equals("diff", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    items = _allItems.Items.Where(i => i.Category.categoryName.Equals("Орехи")).OrderBy(i => i.id);
                    currCategory = "Орехи";
                }

               
            }
            var itemObj = new ItemsListViewModel
            {
                AllItems = items,
                currCategory = currCategory
            };

  
            ViewBag.Title = "Сухофрукты 45";
            return View(itemObj);
        }
    }
}
