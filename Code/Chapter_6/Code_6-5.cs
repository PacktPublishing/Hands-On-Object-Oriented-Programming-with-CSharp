using System;

namespace Chapter6
{
    delegate void MathFunc(ref int a);

    class Code_6_5
    {
        static void Main(string[] args)
        {
            MathFunc mf;
            MathFunc myAdd = MyMath.add5;
            MathFunc mySub = MyMath.sub3;
            MathFunc myMul = MyMath.mul10;

            mf = myAdd;
            mf += mySub;

            int number = 10;

            mf(ref number);

            mf -= mySub;
            mf += myMul;

            number = 10;

            mf(ref number);


            Console.WriteLine($"Final number: {number}");

            Console.ReadKey();
        }
    }

    class MyMath
    {
        public static void add5(ref int a)
        {
            a = a + 5;
            Console.WriteLine($"After adding 5 the answer is {a}");
        }

        public static void sub3(ref int a)
        {
            a = a - 3;
            Console.WriteLine($"After subtracting 3 the answer is {a}");
        }

        public static void mul10(ref int a)
        {
            a = a * 10;
            Console.WriteLine($"After multiplying 10 the answer is {a}");
        }
    }
}