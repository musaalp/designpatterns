using ChainOfResponsibility.AnotherSample;
using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new Authenticator(new Logger(new Compressor(null)));                                    

            var server = new WebServer(handler);
            server.Handle(new HttpRequest("admin", "12345"));
        }
    }
}
