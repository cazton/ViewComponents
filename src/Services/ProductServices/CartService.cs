using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Interfaces;
using BlogViewComponent.Core.Models;
using BlogViewComponent.Services.ProductServices.Interfaces;

namespace BlogViewComponent.Services.ProductServices
{
    public class CartService : ICartService
    {
        private const decimal TaxPercentag = 8.25m;
        private readonly IList<ProductItemModel> _selectedItems = new List<ProductItemModel>();
        private readonly IProductRepo _productRepo;

        public CartService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
            GenerateCart();
        }

        public IList<ProductItemModel> GetCartItems(int cartId)
        {
            return _selectedItems;
        }

        public CartTotalsModel GetCartTotals(int cartId)
        {
            return new CartTotalsModel
            {
                Subtotal = _selectedItems.Aggregate(0m, (current, selectedItem) => current + selectedItem.Price),
                Tax = _selectedItems.Aggregate(0m, (current, selectedItem) => current + selectedItem.Price) * (TaxPercentag / 100),
                ShippingAmount = 20m
            };
        }

        #region Helper Methods

        private void GenerateCart()
        {
            var random = new Random();
            var productItems = _productRepo.GetItems();

            for (var i = 0; i < 3; i++)
            {
                _selectedItems.Add(productItems[random.Next(0, productItems.Count)]);
            }
        }

        #endregion
    }
}
