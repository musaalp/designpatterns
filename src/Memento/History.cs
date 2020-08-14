using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class History
    {
        private Stack<EditorState> _stack = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            _stack.Push(state);
        }

        public EditorState Pop()
        {
            return _stack.Pop();
        }
    }
}
