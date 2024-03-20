using System;
namespace OOD_Ex2
{
    class Truck : Vehicle
    {
        public Truck(string make, string model, int year, string color) : base(make, model, year, color, "Truck")
        {

        }

        public double CalculateServiceCost()
        {
            return 350;
        }
    }
}

