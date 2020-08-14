namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var generalManagerComposition = new CompositeComponent<IOrganizationComposite>
            {
                Node = new GeneralManager("Masai Ujiri")
            };

            var headCoachComposition = generalManagerComposition.Add(new HeadCoach("Nick Nurse"));

            var assistantCoachComposition = headCoachComposition.Add(new AssistantCoach("Jim Sann"));

            assistantCoachComposition.Add(new Player("Kahwi Leonard"));
            assistantCoachComposition.Add(new Player("Kyle Lowry"));
            assistantCoachComposition.Add(new Player("SergeIbaka"));
            assistantCoachComposition.Add(new Player("Pascal Siakam"));

            generalManagerComposition.List(0);
        }
    }
}
