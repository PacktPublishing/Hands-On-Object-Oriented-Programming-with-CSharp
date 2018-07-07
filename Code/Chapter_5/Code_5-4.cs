using System;

namespace Chapter5
{
    class Code_5_4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("You are the boss!");
                throw new DivideByZeroException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range!");
                Console.WriteLine("Exception: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero!");
                Console.WriteLine("Exception: " + ex);
            }
            catch
            {
                Console.WriteLine("I will catch you exception! You can't hide from me!");
            }

            Console.WriteLine("See, i told you!");
            Console.ReadKey();
        }
    }
}