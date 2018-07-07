using System;

namespace Chapter5
{
    class Code_5_5
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 5;
                int c = b / a;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range!");
                System.Console.WriteLine("Exception: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero!");
                System.Console.WriteLine("Exception: " + ex);
            }
            catch
            {
                Console.WriteLine("I will catch you exception! You can't hide from me!");
            }

            finally
            {
                Console.WriteLine("I am the finally block i will run by hook or by crook!");
            }
        }
    }
}