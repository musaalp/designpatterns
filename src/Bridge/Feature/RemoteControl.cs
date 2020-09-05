using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Feature
{
    public class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
