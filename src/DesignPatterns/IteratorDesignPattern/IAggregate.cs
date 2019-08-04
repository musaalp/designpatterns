namespace IteratorDesignPattern
{
    public interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }
}
