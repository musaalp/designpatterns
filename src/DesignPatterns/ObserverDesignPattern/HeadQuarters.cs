using System.Collections.Generic;

namespace ObserverDesignPattern
{
    /// <summary>
    /// abstract subject
    /// </summary>
    public abstract class HeadQuarters
    {
        private List<IOperator> _operators = new List<IOperator>();

        public HeadQuarters(string information)
        {
            Information = information;
        }

        public void Attach(IOperator @operator)
        {
            _operators.Add(@operator);
        }

        public void Detach(IOperator @operator)
        {
            _operators.Remove(@operator);
        }

        private string _information;
        public string Information
        {
            get
            {
                return _information;
            }
            set
            {
                _information = value;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var @operator in _operators)
            {
                @operator.Update(this);
            }
        }
    }
}
