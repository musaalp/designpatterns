using System.Collections.Generic;

namespace ProxyDesignPattern
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
