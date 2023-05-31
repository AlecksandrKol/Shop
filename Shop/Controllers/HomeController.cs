using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllItems _itemRep;

        public HomeController(IAllItems itemRep)
        {
            _itemRep = itemRep;
        }

        public ViewResult Index()
        {
            var homeItems = new HomeViewModel
            {
                favItems = _itemRep.getFavItems
            };
            return View(homeItems);
        }
    }
}
