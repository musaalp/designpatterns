using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            var isValid = httpRequest.Username == "admin" && httpRequest.Password == "12345";

            Console.WriteLine("Authentication");

            return isValid;
        }
    }
}
