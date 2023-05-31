using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Linq;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllItems _itemRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllItems itemRep, ShopCart shopCart)
        {
            _itemRep = itemRep;
            _shopCart = shopCart;
        }
        
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel { shopCart = _shopCart };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _itemRep.Items.FirstOrDefault(i => i.id == id);
            if (item != null) 
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
