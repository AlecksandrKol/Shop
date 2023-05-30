using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

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

        public ViewResult List()
        {
            ItemsListViewModels obj = new ItemsListViewModels();
            obj.AllItems = _allItems.Items;
            obj.currCategory = "";
            ViewBag.Title = "Сухофрукты 45";
            return View(obj);
        }
    }
}
