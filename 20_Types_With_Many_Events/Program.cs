using System;
using System.Collections.Generic;

namespace _20_Types_With_Many_Events
{
    class Cow
    {
        private Dictionary<string, EventHandler> subscribers = new Dictionary<string, EventHandler>();
        const string BeginMooKey = "Begin moo";

        public event EventHandler BeginMoo
        {
            add
            {
                AddSubscriber(BeginMooKey, value);
            }
            remove
            {
                if (!subscribers.ContainsKey(BeginMooKey))
                    return;
                subscribers[BeginMooKey] -= value;
                if (subscribers[BeginMooKey] == null)
                    subscribers.Remove(BeginMooKey);

            }
        }

        void AddSubscriber(string key, EventHandler subscriber)
        {
            if (subscribers.ContainsKey(BeginMooKey))
                subscribers[BeginMooKey] += subscriber;
            else
                subscribers.Add(BeginMooKey, subscriber);
        }

        public event EventHandler Moo;
        public event EventHandler EndMoo;
        public event EventHandler BeginWalking;
        public event EventHandler Walk;
        public event EventHandler EndWalking;
        public event EventHandler BeginSleeping;
        public event EventHandler Sleeping;
        public event EventHandler EndSleeping;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
