using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _pointIcons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!_pointIcons.ContainsKey(pointType))
            {
                var pointIcon = new PointIcon(pointType, null);
                _pointIcons.Add(pointType, pointIcon);
            }

            return _pointIcons[pointType];
        }
    }
}
