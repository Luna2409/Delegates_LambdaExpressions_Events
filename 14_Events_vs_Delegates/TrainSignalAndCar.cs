using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Events_vs_Delegates
{
    class TrainSignal
    {
        public event Action TrainsAComing;
        public void HereComesATrain()
        {
            // there is a ton of logic there
            if(TrainsAComing != null)
                TrainsAComing.Invoke();
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
