using System;

namespace _9_Anonymous_Methods_vs_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Methods 
            //Func<int, bool> func = delegate (int i) { return i > 5 };

            //Lambda Expression
            //Func<int, bool> func = i => i > 5; 
            Func<int, string, bool> func = (int i, string s) => i > 5;

            Console.WriteLine(func(3, "hello"));
            Console.WriteLine(func(7, "hello"));
        }
    }
}
