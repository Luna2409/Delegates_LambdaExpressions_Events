using System;

namespace _14_Events_vs_Delegates
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

            // Because TrainsAComing is an event it can only appear on the left hand side of += or -= (exept from within th type TrainSignal)
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing = null;

            // later on...
            trainSignal.HereComesATrain();
        }
    }
}
