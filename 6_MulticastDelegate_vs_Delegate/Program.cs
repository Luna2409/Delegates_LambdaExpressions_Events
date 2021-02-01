using System;
using System.Collections.Generic;

namespace _6_MulticastDelegate_vs_Delegate
{
    delegate int MeDelegate();

    class Program
    {
        static void Main()
        {
            // Delegate => MulticastDelegate -> MeDelegate
            MeDelegate d = ReturnFive;
            d += ReturnTen;
            d += Return22;
            
            foreach (int i in GetAllReturnValues(d))
                Console.WriteLine(i);
        }

        static List<int> GetAllReturnValues(MeDelegate d)
        {
            List<int> ints = new List<int>();
            foreach (MeDelegate del in d.GetInvocationList())
                ints.Add(del());
            return ints;
        } 

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int Return22() { return 22; }
    }
}
