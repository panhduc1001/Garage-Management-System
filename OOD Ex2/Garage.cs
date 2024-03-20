using System;
namespace OOD_Ex2
{
    class Garage
    {
        // List
        private List<Vehicle> vehicles;

        // Constructor
        public Garage()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            // Add a vehicle to list vehicles
            if (vehicles.Contains(vehicle))
            {
                Console.WriteLine("This vehicle is already in the garage!\n");
            }
            else
            {
                vehicles.Add(vehicle);
                Console.WriteLine($"'{vehicle.Make}' is added to the garage.\n");
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            // Remove a vehicle out of garage
            if (!vehicles.Contains(vehicle))
            {
                Console.WriteLine($"'{vehicle.Make}' is not in the garage!\n");
            }
            else
            {
                vehicles.Remove(vehicle);
                Console.WriteLine($"'{vehicle.Make}' is removed from the garage.\n");
            }
        }

        public void DisplayAllVehicles()
        {
            foreach(var vehicle in vehicles)
            {
                // Use DisplayInfo()
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}

