namespace ObserverDesignPattern
{
    /// <summary>
    /// abstract observer
    /// </summary>
    public interface IOperator
    {
        void Update(HeadQuarters headQuarters);
    }
}
