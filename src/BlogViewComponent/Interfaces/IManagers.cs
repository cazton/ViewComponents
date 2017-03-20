using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;

namespace BlogViewComponent.Interfaces
{
    public interface IProductManager
    {
        IList<int> GetAllItemIds();
        ProductItemModel GetById(int productId);
    }

    public interface ICartManager
    {
        CartTotalsModel GetCartTotals(int cartId);
        IList<int> GetCartItems(int cartId);
    }
}
