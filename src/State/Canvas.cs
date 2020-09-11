using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Canvas
    {
        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

        public ITool CurrentTool { get; set; }
    }
}
