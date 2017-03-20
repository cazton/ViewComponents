using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class CartItemsViewComponent : ViewComponent
    {
        private readonly ICartManager _cartManager;

        public CartItemsViewComponent(ICartManager cartManager)
        {
            _cartManager = cartManager;
        }

        public IViewComponentResult Invoke(int cartId)
        {
            var cartItemIds = _cartManager.GetCartItems(cartId);
            return View(cartItemIds);
        }
    }
}
