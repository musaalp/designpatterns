using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
