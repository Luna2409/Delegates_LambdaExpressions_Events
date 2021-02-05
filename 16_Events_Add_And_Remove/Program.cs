using System;

namespace _16_Events_Add_And_Remove
{
    class Program
    {
        static void Main()
        {
            Cow c = new Cow();
            c.Mooing += () => Console.WriteLine("Giggle");
            c.PushSleepingCow();
        }
    }
}
