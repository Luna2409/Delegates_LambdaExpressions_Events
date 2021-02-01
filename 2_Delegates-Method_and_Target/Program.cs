using System;

namespace Delegates_Method_and_Target
{
    delegate void MeDelegate(int value);

    class Program
    {
        static void Main()
        {
            MeDelegate del = Foo;
            Console.WriteLine(del.Method);
            Console.WriteLine(del.Target);
            Program m = new Program();
            m.Goo(5);
            del = m.Goo;
            Console.WriteLine(del.Method);
            Console.WriteLine(del.Target);
        }

        static void Foo(int u) { }
        void Goo(int asdf) { }
    }
}