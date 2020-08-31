namespace Prototype
{
    public class CloneFactory
    {
        public IAnimal GetClone(IAnimal animal)
        {
            return animal.MakeCopy();
        }
    }
}
