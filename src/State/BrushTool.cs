using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Draw a line");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush icon");
        }
    }
}
