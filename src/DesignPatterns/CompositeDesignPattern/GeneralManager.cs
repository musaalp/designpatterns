namespace CompositeDesignPattern
{
    public class GeneralManager : User, IOrganizationComposite
    {
        public GeneralManager(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
