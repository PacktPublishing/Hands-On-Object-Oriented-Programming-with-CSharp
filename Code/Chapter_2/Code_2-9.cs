using System;

namespace Chapter2
{
    public abstract class Vehicle
    {
        public abstract int GetNumberOfTyres();
    }

    public class Bicycle : Vehicle
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int NumberOfTyres { get; set; }

        public override int GetNumberOfTyres()
        {
            return NumberOfTyres;
        }
    }

    public class Car : Vehicle
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int FrontTyres { get; set; }
        public int BackTyres { get; set; }

        public override int GetNumberOfTyres()
        {
            return FrontTyres + BackTyres;
        }
    }
}