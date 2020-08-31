namespace Prototype
{
    public class Sheep : IAnimal
    {
        public Sheep(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone() as Sheep;
        }

        public IAnimal MakeCopy()
        {
            return Clone() as Sheep;
        }
    }
}
