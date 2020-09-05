using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Implementation
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung: set channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: turn on");
        }
    }
}
