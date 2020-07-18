using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "A";
            history.Push(editor.CreateState());

            editor.Content = "B";
            history.Push(editor.CreateState());

            editor.Content = "C";
            history.Push(editor.CreateState());

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}
