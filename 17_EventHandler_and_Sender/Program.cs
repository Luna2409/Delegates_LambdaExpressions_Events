using System;

namespace _17_EventHandler_and_Sender
{
    class Cow
    {
        public string Name { get; set; }
        public event EventHandler Moo;
        public void BeTippedOver()
        {
            if (Moo != null)
                Moo(this, EventArgs.Empty);
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

        static void giggle(object sender, EventArgs e)
        {
            Cow c = sender as Cow;
            Console.WriteLine("Giggle giggle... We made " + c.Name + " moo!");
        }
    }
}
