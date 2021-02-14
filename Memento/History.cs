using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class History
    {
        Stack<EditorState> states = new Stack<EditorState>();

        public EditorState Pop()
        {
            return states.Pop();
        }

        public void Push(EditorState state)
        {
            states.Push(state);
        }
    }
}
