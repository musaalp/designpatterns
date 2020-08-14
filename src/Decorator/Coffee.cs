using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Coffee : ICoffee
    {
        public void Cook()
        {
            Console.WriteLine("A coffee cooked.");
        }
    }
}
