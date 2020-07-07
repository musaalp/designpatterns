using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public interface IHtmNode
    {
        void Execute(IVisitor visitor);
    }
}
