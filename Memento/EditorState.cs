using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class EditorState
    {
        private readonly string mContent;

        public string Content
        {
            get
            {
                return mContent;
            }
        }

        public EditorState(string content)
        {
            this.mContent = content;
        }



    }
}
