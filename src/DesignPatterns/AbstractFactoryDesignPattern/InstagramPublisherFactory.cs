using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class InstagramPublisherFactory : IPublisherFactory
    {
        public IContent CreateContentObject()
        {
            return new ImageContent();
        }

        public IPublisher CreatePublisher()
        {
            return new InstagramPublisher
            {
                PublisherAddress = "http://www.instagram.com"
            };
        }
    }
}
