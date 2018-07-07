using System;

namespace Chapter6
{
    delegate int MathFunc(int a, int b);

    class Code_6_1
    {
        static void Main(string[] args)
        {
            MathFunc mf = new MathFunc(add);

            Console.Write("Add: ");
            Console.WriteLine(mf(4, 5));

            mf = new MathFunc(sub);

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