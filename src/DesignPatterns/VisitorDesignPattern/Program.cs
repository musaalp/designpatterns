using System;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.Add(new HeadingNode());
            htmlDocument.Add(new AnchorNode());

            htmlDocument.Execute(new HighlightVisitor());
            htmlDocument.Execute(new PlainTextHighlightVisitor());
        }
    }
}
