using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Implementation
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
