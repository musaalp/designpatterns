namespace AbstractFactoryDesignPattern
{
    public interface IPublisher
    {
        string PublisherAddress { get; set; }
        void Publish(IContent content);
    }
}
