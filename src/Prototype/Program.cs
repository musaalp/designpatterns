using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CloneFactory();

            var sheep = new Sheep("SHP1");
            Console.WriteLine($"Sheep name: {sheep.Name}, Hashcode: {sheep.GetHashCode()}");

            var sheepClone = factory.GetClone(sheep);
            Console.WriteLine($"Sheep name: {sheepClone.Name}, Hashcode: {sheepClone.GetHashCode()}");
        }
    }
}
