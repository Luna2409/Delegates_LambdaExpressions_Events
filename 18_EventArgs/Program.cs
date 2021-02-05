using System;

namespace _18_EventArgs
{
    public enum CowState
    {
        Awake,
        Sleeping, 
        Dead
    }

    class CowTippedEventArgs : EventArgs
    {
        public CowState CurrentCowState { get; private set; }
        public CowTippedEventArgs(CowState currentState)
        {
            CurrentCowState = currentState;
        }
    }

    class Cow
    {
        public string Name { get; set; }
        public event EventHandler<CowTippedEventArgs> Moo;
        public void BeTippedOver()
        {
            if (Moo != null)
                Moo(this, new CowTippedEventArgs(CowState.Awake));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cow c1 = new Cow { Name = "Betsy" };
            c1.Moo += giggle;
            Cow c2 = new Cow { Name = "Georgy" };
            c2.Moo += giggle;
            Cow victim = new Random().Next() % 2 == 0 ? c1 : c2;
            victim.BeTippedOver();
        }

        static void giggle(object sender, CowTippedEventArgs e)
        {
            Cow c = sender as Cow;
            Console.WriteLine("Giggle giggle... We made " + c.Name + " moo!");
            switch (e.CurrentCowState)
            {
                case CowState.Awake:
                    Console.WriteLine("Run!");
                    break;
                case CowState.Sleeping:
                    Console.WriteLine("Tickle it");
                    break;
                case CowState.Dead:
                    Console.WriteLine("Butcher it");
                    break;
                default:
                    break;
            }
        }
    }
}
