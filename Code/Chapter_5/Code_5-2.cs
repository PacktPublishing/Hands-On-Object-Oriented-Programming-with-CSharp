using System;

namespace Chapter5
{
    class Code_5_2
    {
        public static void Main()
        {
            try
            {
                var zero = 0;
                Console.WriteLine("Here we will divide 5 by 0");
                var a = 5 / zero;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index is out of range!");
                Console.WriteLine("Exception: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You have divided by zero, which is not correct!");
                Console.WriteLine("Exception: " + ex);
            }
        }
    }
}