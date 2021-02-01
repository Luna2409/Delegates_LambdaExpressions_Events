using System;

namespace Delegates_LambdaExpressions_Events
{
    delegate void MeDelegate();
    //class MeDelegate { }

    class Program
    {
        static void Main(string[] args)
        {
            InvokeTheDelegate(Foo);
            InvokeTheDelegate(Goo);
        }

        static void InvokeTheDelegate(MeDelegate deler)
        {
            deler();
        }

        static void Foo()
        {
            Console.WriteLine("Foo()");
        }

        static void Goo()
        {
            Console.WriteLine("Goo()");
        }
    }
}