
using System;

namespace Chapter6
{
    delegate int MathFunc(int a, int b);

    class Code_6_3
    {
        static void Main(string[] args)
        {
            MyMath mc = new MyMath();
            MathFunc mf = mc.add;

            Console.Write("Add: ");
            Console.WriteLine(mf(4, 5));

            mf = mc.sub;

            Console.Write("Sub: ");
            Console.WriteLine(mf(4, 5));
            Console.ReadKey();
        }
    }

    class MyMath
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return (a > b) ? (a - b) : (b - a);
        }
    }
}