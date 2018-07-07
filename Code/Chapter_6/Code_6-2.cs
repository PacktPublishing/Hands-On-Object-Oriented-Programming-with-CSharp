using System;

namespace Chapter6
{
    delegate int MathFunc(int a, int b);

    class Code_6_2
    {
        static void Main(string[] args)
        {
            MathFunc mf = add;

            Console.Write("Add: ");
            Console.WriteLine(mf(4, 5));

            mf = sub;

            Console.Write("Sub: ");
            Console.WriteLine(mf(4, 5));
            Console.ReadKey();
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return (a > b) ? (a - b) : (b - a);
        }
    }
}