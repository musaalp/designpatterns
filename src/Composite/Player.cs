namespace CompositeDesignPattern
{
    public class Player : User, IOrganizationComposite
    {
        public Player(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
