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

	class Code_7_1
	{
		static void Main(string[] args)
		{
			Price<int> price = new Price<int>(55);

			price.PrintType();

			int a = price.GetPrice();

			Console.WriteLine("The price is " + a);

			Console.ReadKey();
		}
	}
}