using System;

namespace EventsAndDelegates
{
    public delegate int DoSomething(B b);

    public class A
    {
        public int value = 5;
    }

    public class B : A { }


    public class Program
    {
        public static int WorkA(A a)
        {
            Console.WriteLine("Method WorkA called: ");
            return a.value * 5;
        }

        public static int WorkB(B b)
        {
            Console.WriteLine("Method WorkB called: ");
            return b.value * 10;
        }


        public static void Main(string[] args)
        {
            B someB = new B();

            DoSomething something = WorkA;

            int result = something(someB);

            Console.WriteLine("The value is " + result);

            Console.ReadLine();
        }
    }
}