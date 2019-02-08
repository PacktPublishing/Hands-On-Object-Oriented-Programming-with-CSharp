using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (var n in numbers)
            {
                if(numbers[3] == n) { break; } 
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}