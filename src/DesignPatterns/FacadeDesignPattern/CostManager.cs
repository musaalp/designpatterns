using System;

namespace FacadeDesignPattern
{
    public class CostManager
    {
        public float ApplyDiscounts(float price, float discount)
        {
            Console.WriteLine($"A discount of {discount} has been applied on the product's price of {price}");

            return price - discount;
        }
    }
}
