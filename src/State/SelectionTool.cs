using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection icon");
        }
    }
}
