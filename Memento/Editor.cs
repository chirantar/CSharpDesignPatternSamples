using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Editor
    {
        private string mContent;

        public string Content
        {
            get { return mContent; }
            set { mContent = value; }
        }

        public EditorState CreateState()
        {
            return new EditorState(mContent);
        }

        public void Restore(EditorState state)
        {
            mContent = state.Content;
        }
    }
}
