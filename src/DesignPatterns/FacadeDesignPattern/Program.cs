namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingFacade = new ShoppingFacade();

            var orderDetailsModel = new OrderDetailsModel
            {
                AddressLine = "Educational Arena",
                CardNo = "0000 00001 00002 00003",
                Discount = 190,
                PinCode = 53353,
                Price = 438,
                ProductName = "A Book"
            };

            shoppingFacade.FinalizeShopping(new OrderDetails(orderDetailsModel));
        }
    }
}
