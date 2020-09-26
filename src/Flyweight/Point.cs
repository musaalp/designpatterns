using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Point
    {
        public Point(int x, int y, PointIcon pointIcon)
        {
            X = x;
            Y = y;
            PointIcon = pointIcon;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public PointIcon PointIcon { get; set; }


        public void Draw()
        {
            Console.Write($"{PointIcon.GetPointType()} at ({X}, {Y})");
        }
    }


}
