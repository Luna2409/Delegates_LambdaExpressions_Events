using System;

namespace _13_Basic_Observer_Pattern_Using_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainSignal trainSignal = new TrainSignal();
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            trainSignal.HereComesATrain();
            Console.WriteLine();
            trainSignal.HereComesATrain();
            Console.WriteLine();
            trainSignal.HereComesATrain();
        }
    }
}
