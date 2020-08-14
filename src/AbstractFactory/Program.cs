namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebookPublisher = new Publisher<FacebookPublisherFactory>();
            facebookPublisher.Publish();

            var twitterPublisher = new Publisher<TwitterPublisherFactory>();
            twitterPublisher.Publish();

            var instagramPublisher = new Publisher<InstagramPublisherFactory>();
            instagramPublisher.Publish();
        }
    }
}
