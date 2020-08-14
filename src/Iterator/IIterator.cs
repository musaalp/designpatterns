namespace IteratorDesignPattern
{
    public interface IIterator<T>
    {
        bool Next();
        T CurrentItem { get; }
    }
}
