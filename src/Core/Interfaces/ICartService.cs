using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;

namespace BlogViewComponent.Core.Interfaces
{
    public interface ICartService
    {
        IList<ProductItemModel> GetCartItems(int cartId);
        CartTotalsModel GetCartTotals(int cartId);
    }
}
