using System;
using System.Collections.Generic;

namespace OOD_Ex2
{
    class Vehicle
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public string Type { get; }

        // Constructor
        public Vehicle(string make, string model, int year, string color, string type)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Type = type;
        }

        public void DisplayInfo()
        {
            // Print all info of a vehicle
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type: {Type}");

        }
    }
}

