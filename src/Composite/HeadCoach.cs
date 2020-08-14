namespace CompositeDesignPattern
{
    public class HeadCoach : User, IOrganizationComposite
    {
        public HeadCoach(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
