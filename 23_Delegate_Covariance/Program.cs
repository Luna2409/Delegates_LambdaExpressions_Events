using System;

namespace _23_Delegate_Covariance
{
    class Base { }
    class Derived : Base { };
    class Derived2 : Base { };

    delegate Base ReturnsBaseDelegate();
    delegate Derived ReturnsDerivedDelegate();

    class Program
    {
        static Base ReturnsBase() { return new Derived2(); }
        static Derived ReturnsDerived() { return null; }

        static void Main(string[] args)
        {
            ReturnsDerivedDelegate b;
            //b = ReturnsBase;
            b = ReturnsDerived;
        }
    }
}
