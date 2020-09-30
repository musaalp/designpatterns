using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AnotherSample
{
    public abstract class Handler
    {
        private readonly Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }


        public void Handle(HttpRequest httpRequest)
        {
            if (!DoHandle(httpRequest))
                return;

            _next?.Handle(httpRequest);
        }

        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}
