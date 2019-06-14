using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class AssistantCoach : User, IOrganizationComposite
    {
        public AssistantCoach(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
