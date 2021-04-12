using System;

namespace Strategy.AnotherSample
{
    // concreate strategy type
    public class DESEncryptor : IEncrytor
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES");
        }
    }
}
