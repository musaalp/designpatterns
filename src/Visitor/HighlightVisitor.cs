using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public class HighlightVisitor : IVisitor
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("hightlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("hightlight-anchor");
        }
    }
}
