namespace Prototype
{
    public class Dog : IAnimal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone() as Dog;
        }

        public IAnimal MakeCopy()
        {
            return Clone() as Dog;
        }
    }
}
