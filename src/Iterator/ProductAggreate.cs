using System.Collections.Generic;

namespace IteratorDesignPattern
{
    public class ProductAggreate : IAggregate<Product>
    {
        private List<Product> _products = new List<Product>();
        public int ProductsCount
        {
            get
            {
                return _products.Count;
            }
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Product GetItem(int index)
        {
            return _products[index];
        }

        public IIterator<Product> GetIterator()
        {
            return new ProductIterator(this);
        }
    }
}
