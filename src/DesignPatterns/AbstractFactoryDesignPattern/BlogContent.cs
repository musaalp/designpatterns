using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class BlogContent : IContent
    {
        public object CreateContent()
        {
            return "Sample blog content has been created.";
        }
    }
}
