using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Editor
    {
        public string Content { get; private set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}
