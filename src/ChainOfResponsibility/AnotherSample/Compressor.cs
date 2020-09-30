using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compress");

            return false;
        }
    }
}
