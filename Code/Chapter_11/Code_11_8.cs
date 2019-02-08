using System;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = "nash";
            switch (person)
            {
                case "john":
                    Console.WriteLine("Hi from john!");
                    break;
                case "smith":
                    Console.WriteLine("Hi from smith!");
                    break;
                case "nash":
                    Console.WriteLine("Hi from nash!");
                    break;
                case "harrold":
                    Console.WriteLine("Hi from harrold!");
                    break;
                default:
                    Console.WriteLine("Hi from None!");
                    break;
            }
            Console.ReadKey();
        }
    }
}