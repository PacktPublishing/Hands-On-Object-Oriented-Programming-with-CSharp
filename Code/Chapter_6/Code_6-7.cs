using System;

namespace EventsAndDelegates
{
    public delegate A DoSomething();

    public class A
    {
        public int value { get; set; }
    }

    public class B : A { }


    public class Program
    {
        public static A WorkA()
        {
            A a = new A();
            a.value = 1;
            return a;
        }

        public static B WorkB()
        {
            B b = new B();
            b.value = 2;
            return b;
        }

        public static void Main(string[] args)
        {
            A someA = new A();

            DoSomething something = WorkB;

            someA = something();

            Console.WriteLine("The value is " + someA.value);

            Console.ReadLine();
        }
    }
}