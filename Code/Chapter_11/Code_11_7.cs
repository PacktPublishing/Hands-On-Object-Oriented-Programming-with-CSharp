using System;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Person();
            person.PrintName("John", "Nash");
            Console.ReadKey();
        }
    }
    public class Person : IPerson
    {
    }
    public interface IPerson
    {
        public void PrintName(string FirstName, string LastName)
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}