using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var productService = Configure().GetRequiredService<IProductService>();

            //assume that here is client
            var productServiceProxy = new ProductServiceProxy(productService);
            var products = productServiceProxy.GetProducts().ToList();

            products.ForEach(p =>
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}");
            });
        }

        private static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IProductService, ProductService>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
