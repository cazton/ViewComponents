using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Interfaces;
using BlogViewComponent.Services.ProductServices.Interfaces;
using BlogViewComponent.Services.ProductServices.Repo;
using Microsoft.Extensions.DependencyInjection;

namespace BlogViewComponent.Services.ProductServices.IoC
{
    public static class Bindings
    {
        public static void Bind(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductRepo, ProductRepo>();
            serviceCollection.AddSingleton<IProductService, ProductService>();
            serviceCollection.AddSingleton<ICartService, CartService>();
        }
    }
}
