using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class TwitterPublisherFactory : IPublisherFactory
    {
        public IContent CreateContentObject()
        {
            return new BlogContent();
        }

        public IPublisher CreatePublisher()
        {
            return new TwitterPublish()
            {
                PublisherAddress = "http://www.twitter.com"
            };
        }
    }
}
