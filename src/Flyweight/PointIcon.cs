using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PointIcon
    {
        private readonly PointType _pointType;
        private readonly byte[] _icon;

        public PointIcon(PointType pointType, byte[] icon)
        {
            _pointType = pointType;
            _icon = icon;
        }

        public PointType GetPointType()
        {
            return _pointType;
        }
    }
}
