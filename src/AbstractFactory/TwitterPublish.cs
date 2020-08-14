using System;

namespace AbstractFactoryDesignPattern
{
    public class TwitterPublish : IPublisher
    {
        public string PublisherAddress { get; set; }

        public void Publish(IContent content)
        {
            var createdContent = content.CreateContent();
            Console.WriteLine($"{createdContent} Published on {PublisherAddress}");
        }
    }
}
