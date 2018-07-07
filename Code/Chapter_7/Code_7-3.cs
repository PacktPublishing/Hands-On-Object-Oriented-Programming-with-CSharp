using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
	class Price
	{
		object ob;

		public Price(object o)
		{
			ob = o;
		}

		public void PrintType()
		{
			Console.WriteLine("The type is " + ob.GetType());
		}

		public object GetPrice()
		{
			return ob;
		}
	}

	class Code_7_3
	{
		static void Main(string[] args)
		{
			Price price = new Price(55);

			price.PrintType();

			int a = (int) price.GetPrice();

			Console.WriteLine("the price is " + a);

			Console.ReadKey();
		}
	}
}