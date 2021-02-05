using System;

namespace _22_Delegate_Contravariance
{
    class Base { }
    class Derived: Base { };

    delegate void MyDelegate(Base b);
    delegate void MyOtherDelegate(Derived d);

    class Program
    {
        static void TakeDerived(Derived d) { }
        static void TakeBase(Base b) { }

        static void Main(string[] args)
        {
            //MyDelegate d1 = TakeDerived;
            //d1(new Derived());
            //d1(new Base());
            //MyDelegate d2 = TakeBase;

            MyOtherDelegate d1 = TakeDerived;
            MyOtherDelegate d2 = TakeBase;
        }
    }
}
