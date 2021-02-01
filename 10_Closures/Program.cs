using System;

namespace _10_Closures
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            a(); 
            a(); 
            a();
        }

        static Action GiveMeAction()
        {
            Action ret = null;
            int i = 0;
            ret += () =>
            {
                Console.WriteLine("First method " + i++);
            };
            ret += () =>
            {
                Console.WriteLine("Second method " + i++);
            };
            return ret;
        }
    }
}
