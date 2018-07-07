using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public interface IFood<in T>
    {
        void PrintMyName(T obj);
    }

    class HealthyFood<T> : IFood<T>
    {
        public void PrintMyName(T obj)
        {
            Console.WriteLine("This is " + obj);
        }
    }

    class Vegetable
    {
        public override string ToString()
        {
            return "Vegetable";
        }
    }

    class Potato : Vegetable
    {
        public override string ToString()
        {
            return "Potato";
        }
    }

    class Code_7_6
    {
        static void Main(string[] args)
        {
            IFood<Potato> mySelf = new HealthyFood<Potato>();
            IFood<Potato> mySelf2 = new HealthyFood<Vegetable>();

            mySelf2.PrintMyName(new Potato());

            Console.ReadKey();
        }
    }
}