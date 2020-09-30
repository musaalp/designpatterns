using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Log");

            return true;
        }
    }
}
