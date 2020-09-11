using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Erase something");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erasericon");
        }
    }
}
