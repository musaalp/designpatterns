using System;

namespace Flyweight
{
    class Program
    {
        // centeralize an instance for efficent sharing accross multiple objects
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());

            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
