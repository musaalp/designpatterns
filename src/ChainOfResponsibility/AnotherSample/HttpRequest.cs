using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public class HttpRequest
    {
        public string Username { get; }
        public string Password { get; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
