using System;

namespace Chapter2
{
    public class Code_2_2
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.firstName = "Jack";
            customer1.lastName = "Jones";
            customer1.phoneNumber = "98745632";
            customer1.emailAddress = "jackjones@email.com";

            Console.WriteLine("First name is " + customer1.firstName);
            Console.ReadKey();
        }
    }

    public class Customer
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string emailAddress;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}