using System;

namespace _8_Delegate_Chains_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action del = (Action)Moo + BeNaughty + Goo;
            foreach (Action a in del.GetInvocationList())
            {
                try
                {
                    a();
                }
                catch {}
            }
        }

        static void Moo() { Console.WriteLine("Moo()"); }
        static void BeNaughty() { throw new Exception(); }
        static void Goo() { Console.WriteLine("Goo()"); }
    }
}
    