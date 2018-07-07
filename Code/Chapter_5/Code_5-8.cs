using System;

namespace Chapter5
{
    class Code_5_8
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };

            try
            {
                Console.WriteLine(a[5]);
            }
            catch (IndexOutOfRangeException ex) when (ex.Message == "Test Message")
            {
                Console.WriteLine("Message:");
                Console.WriteLine("Test Message");
            }
            catch (IndexOutOfRangeException ex) when (ex.Message == "Index was outside the bounds of the array.")
            {
                Console.WriteLine("Message:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stack Trace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("String:");
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}