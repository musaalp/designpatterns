using Bridge.Feature;
using Bridge.Implementation;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControler = new RemoteControl(new SamsungTV());

            remoteControler.TurnOn();
            remoteControler.TurnOff();

            var movieRemoteController = new MovieRemoteControl(new SonyTV());

            movieRemoteController.SetChannel(3);
        }
    }
}
