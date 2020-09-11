using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //first sample
            var canvas = new Canvas();
            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();

            //second sample
            DrawUIControl(new TextBox());
            DrawUIControl(new Checkbox());
        }

        static void DrawUIControl(UIControl control)
        {
            control.Draw();
        }
    }
}
