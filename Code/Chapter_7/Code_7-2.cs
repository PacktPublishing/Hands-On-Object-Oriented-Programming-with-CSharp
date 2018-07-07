using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Price<T>
    {
        T ob;

        public Price(T o)
        {
            ob = o;
        }

        public void PrintType()
        {
            Console.WriteLine("The type is " + typeof(T));
        }

        public T GetPrice()
        {
            return ob;
        }
    }

    class Code_7_2
    {
        static void Main(string[] args)
        {
            Price<int> price = new Price<int>(55);

            price.PrintType();

            int a = price.GetPrice();

            Console.WriteLine("the price is " + a);

            Price<string> priceStr = new Price<string>("Hello People");

            priceStr.PrintType();

            string b = priceStr.GetPrice();

            Console.WriteLine("the string is " + b);

            Console.ReadKey();
        }
    }
}