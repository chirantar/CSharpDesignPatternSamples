/*
 *  Used to implement undo pattern in code 
 *  below implementation is used to restore last state of editor content
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();
            editor.Content = "a";
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            Console.Read();
        }
    }
}
