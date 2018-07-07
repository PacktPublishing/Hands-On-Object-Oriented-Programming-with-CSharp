using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
	class Hello
	{
		public static T Larger<T>(T a, T b) where T: IComparable<T>
		{
			return a.CompareTo(b) > 0 ? a : b;
		}
	}

	class Code_7_4
	{
		static void Main(string[] args)
		{
			int result = Hello.Larger<int>(3, 4);

			double doubleResult = Hello.Larger<double>(4.3, 5.6);

			Console.WriteLine("The Large value is " + result);
			Console.WriteLine("The Double Large value is " + doubleResult);

			Console.ReadKey();
		}
	}
}
