using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Interfaces;
using BlogViewComponent.Core.Models;
using BlogViewComponent.Interfaces;

namespace BlogViewComponent.Managers
{
    public class CartManager : ICartManager
    {
        private readonly ICartService _cartService;
        private readonly IProductService _productService;

        public CartManager(ICartService cartService, IProductService productService)
        {
            _cartService = cartService;
            _productService = productService;
        }

        #region ICartManager Methods

        public CartTotalsModel GetCartTotals(int cartId)
        {
            return _cartService.GetCartTotals(cartId);
        }

        public IList<int> GetCartItems(int cartId)
        {
            var cartItems = _cartService.GetCartItems(cartId);
            return cartItems.Select(x => x.Id).ToList();
        }

        #endregion
    }
}
