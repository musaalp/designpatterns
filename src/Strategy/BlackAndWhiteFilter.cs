namespace StrategyDesignPattern
{
    // concreate strategy type
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            System.Console.WriteLine("Applying black and white filter");
        }
    }
}
