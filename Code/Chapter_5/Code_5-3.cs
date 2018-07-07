using System;

namespace Chapter5
{
    class Code_5_3
    {
        static void Main(string[] args)
        {
            try
            {
                var a = 0;
                var b = 5;
                var c = b / a;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range!");
                Console.WriteLine("Exception: " + ex);
            }
            catch
            {
                Console.WriteLine("I will catch you exception! You can't hide from me!");
            }

            Console.WriteLine("Hello. You will also see me.");
            Console.ReadKey();
        }
    }
}