namespace AbstractFactoryDesignPattern
{
    public class FacebookPublisherFactory : IPublisherFactory
    {
        public IContent CreateContentObject()
        {
            return new VideoContent();
        }

        public IPublisher CreatePublisher()
        {
            return new FacebookPublisher
            {
                PublisherAddress = "http://www.facebook.com"
            };
        }
    }
}
