using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Basic_Observer_Pattern_Using_Delegates
{
    class TrainSignal
    {
        public Action TrainsAComing;
        public void HereComesATrain()
        {
            // there is a ton of logic there
            TrainsAComing();
        }
    }

    class Car
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.TrainsAComing += StopTheCar;
        }
        void StopTheCar()
        {
            Console.WriteLine("Screeeetch");
        }
    }
}
