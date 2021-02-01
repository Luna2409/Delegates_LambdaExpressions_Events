using System;

namespace _11_How_The_Compiler_Implements_Closures
{
    class Program
    {
        class DisplayClass
        {
            public int i;
            public void TheMethodGeneratedFromTheLambdaExpression()
            {
                i++;
            }
        }

        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            a();
            Action b = GiveMeAction();
            b(); a(); a(); b(); a();
        }

        static Action GiveMeAction()
        {
            return new Action(new DisplayClass().TheMethodGeneratedFromTheLambdaExpression);
        }
    }
}
