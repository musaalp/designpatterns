using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    /// <summary>
    /// concreate subject
    /// </summary>
    public class RedFleet : HeadQuarters
    {
        public RedFleet(string information) : base(information)
        {
        }
    }
}
