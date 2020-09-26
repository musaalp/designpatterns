using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointService
    {
        private readonly PointIconFactory _pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }

        public List<Point> GetPoints()
        {
            var pointIconFactory = new PointIconFactory();
            var points = new List<Point>();
            var point = new Point(1, 2, _pointIconFactory.GetPointIcon(PointType.Cafe));

            points.Add(point);

            return points;
        }
    }
}
