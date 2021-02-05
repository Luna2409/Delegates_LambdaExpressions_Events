using System;

namespace _12_More_Complex_Closures
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            b(); a(); a(); a(); b(); a();
        }

        static Action GiveMeAction()
        {
            Action ret = null;
            int i = 0;
            int j = 5;
            ret += () => i++;
            ret += () => j++;
            ret += () => { i++; j++; };
            return ret;
        }
    }
}
