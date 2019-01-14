using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class SugarDecorator : Decorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override void Cook()
        {
            base.Cook();
            Console.WriteLine("Sugar added.");
        }
    }
}
