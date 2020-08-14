using ProxyDesignPattern;
using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = $"Product {i}"
                };

                products.Add(product);
            }

            return products;
        }
    }
}
