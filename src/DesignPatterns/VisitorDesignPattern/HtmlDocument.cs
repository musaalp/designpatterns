using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public class HtmlDocument
    {
        private List<IHtmNode> _nodes = new List<IHtmNode>();

        public void Add(IHtmNode htmNode)
        {
            _nodes.Add(htmNode);
        }

        public void Execute(IVisitor visitor)
        {
            foreach (var node in _nodes)
            {
                node.Execute(visitor);
            }
        }
    }
}
