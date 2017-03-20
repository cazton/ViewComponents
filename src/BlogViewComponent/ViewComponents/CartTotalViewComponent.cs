using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class CartTotalViewComponent : ViewComponent
    {
        private readonly ICartManager _cartManager;

        public CartTotalViewComponent(ICartManager cartManager)
        {
            _cartManager = cartManager;
        }

        public IViewComponentResult Invoke(int cartId)
        {
            var cartTotals = _cartManager.GetCartTotals(cartId);
            return View(cartTotals);
        }
    }
}
