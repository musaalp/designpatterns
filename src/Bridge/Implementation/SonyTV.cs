using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Implementation
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: set channel");
        }
    }
}
