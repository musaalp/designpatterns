namespace IteratorDesignPattern
{
    class Program
    {
        // Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
        static void Main(string[] args)
        {
            var productsAggregate = new ProductAggreate();
            productsAggregate.Add(new Product { Id = 1, Name = "P1" });
            productsAggregate.Add(new Product { Id = 2, Name = "P2" });
            productsAggregate.Add(new Product { Id = 3, Name = "P3" });

            var productIterator = productsAggregate.GetIterator();

            while (productIterator.Next())
            {
                var currentItem = productIterator.CurrentItem;
                System.Console.WriteLine($"Id: {currentItem.Id}, Name: {currentItem.Name}");
            }
        }
    }
}
