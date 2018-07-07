using System;

namespace Chapter5
{
    class HelloException : Exception
    {
        public HelloException() { }
        public HelloException(string message) : base(message) { }
        public HelloException(string message, Exception inner) : base(message, inner) { }
    }

    class Code_5_7
    {
        static void Main(string[] args)
        {
            try
            {
                throw new HelloException("Hello this is an exception!");
            }
            catch (HelloException ex)
            {
                Console.WriteLine("Exception Message:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}