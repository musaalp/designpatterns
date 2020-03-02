namespace StrategyDesignPattern
{
    // strategy type interface
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
