using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;
using BlogViewComponent.Services.ProductServices.Interfaces;

namespace BlogViewComponent.Services.ProductServices.Repo
{
    /// <summary>
    /// This is temporary repo 
    /// </summary>
    public class ProductRepo : IProductRepo
    {
        private readonly IList<ProductItemModel> _items = new List<ProductItemModel>();

        public ProductRepo()
        {
            GenerateItems();
        }

        public IList<ProductItemModel> GetItems()
        {
            return _items;
        }

        #region Helper Methods

        //Since this is test solution...we don't need to go to a DB to get this data
        private void GenerateItems()
        {
            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                _items.Add(new ProductItemModel
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = "Cupcake ipsum dolor sit. Amet I love liquorice jujubes pudding croissant I love pudding. Apple pie macaroon toffee jujubes pie tart cookie applicake caramels. Halvah macaroon I love lollipop. Wypas I love pudding brownie cheesecake tart jelly-o. Bear claw cookie chocolate bar jujubes toffee",
                    Price = random.Next(1000, 5000),
                    ImageName = "Computer"
                });
            }
        }

        #endregion
    }
}
