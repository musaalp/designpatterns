namespace AbstractFactoryDesignPattern
{
    public interface IPublisherFactory
    {
        IContent CreateContentObject();
        IPublisher CreatePublisher();
    }
}
