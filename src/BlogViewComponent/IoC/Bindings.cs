using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Interfaces;
using BlogViewComponent.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace BlogViewComponent.IoC
{
    public static class Bindings
    {
        public static void Bind(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductManager, ProductManager>();
            serviceCollection.AddSingleton<ICartManager, CartManager>();
        }
    }
}
