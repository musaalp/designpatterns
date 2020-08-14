namespace IteratorDesignPattern
{
    public class ProductIterator : IIterator<Product>
    {
        private readonly ProductAggreate _productAggreate;
        private int _index;

        public ProductIterator(ProductAggreate productConcreteAggreate)
        {
            _productAggreate = productConcreteAggreate;
        }

        public Product CurrentItem { get; private set; }

        public bool Next()
        {

            if (_index < _productAggreate.ProductsCount)
            {
                CurrentItem = _productAggreate.GetItem(_index++);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
