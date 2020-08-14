using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public class ProductServiceProxy : IProductService
    {
        private readonly IProductService _productService;

        public ProductServiceProxy(IProductService productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }
    }
}
