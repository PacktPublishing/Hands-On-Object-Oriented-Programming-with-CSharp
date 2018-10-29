using System;

namespace Chapter2
{
    public class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public class Apple : Fruit
    {
        public int NumberOfSeeds { get; set; }
    }
}