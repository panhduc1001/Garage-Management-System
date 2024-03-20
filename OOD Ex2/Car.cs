using System;
namespace OOD_Ex2
{
    class Car : Vehicle
    {
        // Constructor
        public Car(string make, string model, int year, string color) : base(make, model, year, color, "Color")
        {

        }

        public double CalculateServiceCost()
        {
            // Add specific logic for calculating service cost for cars
            return 200;
        }
    }
}

