namespace AbstractFactoryDesignPattern
{
    public class Publisher<T> where T : IPublisherFactory, new()
    {
        private readonly IContent _content;
        private readonly IPublisher _publisher;
        private readonly T _factory;

        public Publisher()
        {
            _factory = new T();
            _content = _factory.CreateContentObject();
            _publisher = _factory.CreatePublisher();
        }

        public void Publish()
        {
            _publisher.Publish(_content);
        }
    }
}
