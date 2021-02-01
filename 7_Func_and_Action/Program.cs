using System;
using System.Collections.Generic;

namespace _6_MulticastDelegate_vs_Delegate
{
    class Program
    {
        static void Main()
        {
            // Delegate => MulticastDelegate -> MeDelegate
            Func<int> d = ReturnFive;
            d += ReturnTen;
            d += Return22;

            // Func always needs to return something
            Func<int, string, bool> f = TakeAnIntAndStringAndReturnABool;

            // Action always returns void
            Action<string> a = TakeAStringAndReturnVoid; 
            foreach (int i in GetAllReturnValues(d))
                Console.WriteLine(i);
        }

        static void TakeAStringAndReturnVoid(string s) { }

        static IEnumerable<TArg> GetAllReturnValues<TArg>(Func<TArg> d)
        {
            foreach (Func<TArg> del in d.GetInvocationList())
                yield return del();
        }

        static bool TakeAnIntAndStringAndReturnABool(int i, string s) 
        {
            return false;
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int Return22() { return 22; }
    }
}
