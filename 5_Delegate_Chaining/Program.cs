using System;
using System.Collections.Generic;

namespace _5_Delegate_Chaining
{
    delegate void MeDelegate();

    class Program
    {
        static void Main() // Delegate -> MulticastDelegate -> MeDelegate
        {
            MeDelegate d = Foo;
            d = (MeDelegate)Delegate.Combine(d, new MeDelegate(Goo));
            d += Sue;
            d += Foo;
            d -= Foo;
            foreach (MeDelegate m in d.GetInvocationList())
                Console.WriteLine(m.Target + ": " + m.Method);
        }
        static void Foo() { Console.WriteLine("Foo()"); }
        static void Goo() { Console.WriteLine("Goo()"); }
        static void Sue() { Console.WriteLine("Sue()"); }
    }
}
