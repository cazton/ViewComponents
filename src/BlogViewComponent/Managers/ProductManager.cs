using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Interfaces;
using BlogViewComponent.Core.Models;
using BlogViewComponent.Interfaces;

namespace BlogViewComponent.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        #region IProductManager Methods

        public IList<int> GetAllItemIds()
        {
            return _productService.GetAllItemIds();
        }

        public ProductItemModel GetById(int productId)
        {
            return _productService.GetById(productId);
        }

        #endregion
    }
}
