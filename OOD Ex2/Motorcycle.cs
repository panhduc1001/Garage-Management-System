using System;
namespace OOD_Ex2
{
    class Motorcycle : Vehicle
    {
        // Constructor
        public Motorcycle(string make, string model, int year, string color) : base(make, model, year, color, "Motorcycle")
        {

        }

        public double CalculateServiceCost()
        {
            return 50;
        }
    }
}

