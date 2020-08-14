using System;

namespace FacadeDesignPattern
{
    public class OrderVerificationManager
    {
        public bool VerifyShippingAddress(int pinCode)
        {
            Console.WriteLine($"The product can be shipped to the pincode {pinCode}");

            return true;
        }
    }
}
