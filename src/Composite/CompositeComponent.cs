using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public class CompositeComponent<TComponent> where TComponent : IComposite
    {
        //a composite component may have a list of composite components
        private List<CompositeComponent<TComponent>> _subComponent = new List<CompositeComponent<TComponent>>();

        public TComponent Node { get; set; }

        public CompositeComponent<TComponent> Add(TComponent component)
        {
            var comp = new CompositeComponent<TComponent>
            {
                Node = component
            };

            _subComponent.Add(comp);

            return comp;
        }

        public void List(int spaceCount)
        {
            var indent = new String(' ', spaceCount++);
            Console.WriteLine($"{indent}{Node.ToString()}, ({_subComponent.Count})");

            foreach (var component in _subComponent)
            {
                component.List(spaceCount);
            }
        }
    }
}
