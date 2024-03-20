using System;
using System.Collections.Generic;

namespace OOD_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a garage
            Garage garage = new Garage();

            // Create car, motorcycle, truck
            Car car = new Car("Ford", "Mustang", 2018, "Grey");
            Motorcycle motorcycle = new Motorcycle("Ducati", "V4", 2022, "Red");
            Truck truck = new Truck("Volvo", "FH16", 2019, "Black");

            // Create a menu for user can choose an options. The menu has:
            //      1. Add a vehicle
            //      2. Remove a vehicle
            //      3. Display all vehicle
            //      4. Exit

            int option = 0;
            while (option != 4)
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add a vehicle");
                Console.WriteLine("2. Remove a vehicle");
                Console.WriteLine("3. Display all vehicle");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out option);

                if(isValid)
                {
                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("Enter your vehicle to add: ");
                            string vehicleInput = Console.ReadLine();
                            switch(vehicleInput.ToLower())
                            {
                                case "car":
                                    garage.AddVehicle(car);
                                    break;
                                case "motorcycle":
                                    garage.AddVehicle(motorcycle);
                                    break;
                                case "truck":
                                    garage.AddVehicle(truck);
                                    break;
                                default:
                                    Console.WriteLine(vehicleInput + " is not existed!\n");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter your vehicle to remove: ");
                            string vehicleInputToRemove = Console.ReadLine();
                            switch (vehicleInputToRemove.ToLower())
                            {
                                case "car":
                                    garage.RemoveVehicle(car);
                                    break;
                                case "motorcycle":
                                    garage.RemoveVehicle(motorcycle);
                                    break;
                                case "truck":
                                    garage.RemoveVehicle(truck);
                                    break;
                                default:
                                    Console.WriteLine(vehicleInputToRemove + " is not existed!\n");
                                    break;
                            }
                            break;

                        case 3:
                            garage.DisplayAllVehicles();
                            break;

                        case 4:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Your option is not valid!\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your option is not valid!\n");
                    option = 0;
                }
            }
        }
    }
}