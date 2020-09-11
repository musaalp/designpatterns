using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class TextBox : UIControl
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a textbox");
        }
    }
}
