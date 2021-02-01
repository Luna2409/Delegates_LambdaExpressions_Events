using System;
using System.Collections.Generic;

namespace Why_Delegates
{
    class Program
    {
        delegate bool MeDelegate(int n);

        static void Main()
        {
            int[] numbers = new[] { 2, 7, 3, 9, 17, 5, 7, 1, 8, 13 };

            IEnumerable<int> result =
                RunNumbersThroughGauntlet(numbers, n => n > 13);
            foreach (int n in result)
                Console.WriteLine(n);
        }

        static IEnumerable<int> RunNumbersThroughGauntlet(
            IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int number in numbers)
                if (gauntlet(number))
                    yield return number;
        }
    }
}
