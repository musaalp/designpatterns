using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public abstract class UIControl
    {
        public void Enable()
        {
            Console.WriteLine("Enabled");
        }

        public abstract void Draw();
    }
}
