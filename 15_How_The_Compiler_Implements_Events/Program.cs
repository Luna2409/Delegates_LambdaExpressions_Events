using System;

namespace _15_How_The_Compiler_Implements_Events
{
    class Cow
    {
        public event Action Mooing;
    }

    class Program
    {
        static void Main()
        {
            Cow c = new Cow();

            // The event Cow.Mooing can only appear on the left side of += or -= (exept when used from within the type Cow)
            //c.Mooing(); 
        }
    }
}
