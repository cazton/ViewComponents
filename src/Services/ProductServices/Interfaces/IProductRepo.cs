using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;

namespace BlogViewComponent.Services.ProductServices.Interfaces
{
    public interface IProductRepo
    {
        IList<ProductItemModel> GetItems();
    }
}
