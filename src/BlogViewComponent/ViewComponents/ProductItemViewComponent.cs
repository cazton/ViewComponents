using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        private readonly IProductManager _productManager;

        public ProductItemViewComponent(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IViewComponentResult Invoke(int productId)
        {
            var productItem = _productManager.GetById(productId);
            return View(productItem);
        }
    }
}
