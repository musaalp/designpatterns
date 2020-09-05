using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Feature
{
    // Basicly it bridge two independent hierarchical dimension
    public class MovieRemoteControl : RemoteControl
    {
        public MovieRemoteControl(IDevice device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
