using Garage.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new Object[]
            //{
            //    "A", "B", 1, 2, 1.1, 2.1, true, false, null, null
            //};
            //var b = a.GroupBy(x => x?.GetType());

            Console.WriteLine("Create a garage");
            var garageHandler = new GarageHandler();

            var vehicleFactory = new VehicleFactory();
            bool state = true;
            Console.WriteLine("You're in the main menu.\n");

            while (state)
            {
                Console.WriteLine("Enter 1 to add a vehicle to the garage");
                Console.WriteLine("Enter 2 to remove a vehicle from the garage");
                Console.WriteLine("Enter 3 to list the vehicles in the garage");
                Console.WriteLine("Enter 4 to list the vehicles type-wise");
                Console.WriteLine("Enter 5 to search a vehicle on registration number");
                Console.WriteLine("Enter 6 to search a vehicle on its property");
                Console.WriteLine("Enter 0 to exit the program");
                bool result = false;

                switch (Helpers.GetMenuChoice(6))
                {
                    case 0:
                        state = false;
                        break;
                    case 1:
                        {
                            Console.WriteLine("Choose which type of vehicle do you want to add?");
                            var vehicle = vehicleFactory.NewVehicle();

                            if (vehicle == null) break;

                            result = garageHandler.AddVehicle(vehicle);
                            if (result)
                                Console.WriteLine("Your vehicle is added to the garage.\n");
                            else
                                Console.WriteLine("Unable to add your vehicle to garage. Please try again!\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the registration number of the vehicle you want to remove: ");
                            var regNum = Console.ReadLine();
                            result = garageHandler.RemoveVehicle(regNum);
                            if (result)
                                Console.WriteLine("Your vehicle is removed from the garage.\n");
                            else
                                Console.WriteLine("Unable to remove your vehicle from garage. Please try again!\n");
                            break;
                        }
                    case 3:
                        {
                            int count = 0;
                            Console.WriteLine("The list of vehicles is:");

                            foreach (var vehicle in garageHandler.ListOfVehicles())
                            {
                                if (vehicle != null)
                                {
                                    Console.WriteLine(vehicle);
                                    count++;
                                }
                            }
                            Console.WriteLine("The number of parked vehicles are " + count);
                            break;
                        }
                    case 4:
                        {
                            foreach (var group in garageHandler.ListOfVehicleTypes())
                            {
                                Console.WriteLine($"{group.Key.Name} ({group.Count()})");
                                foreach (var vehicle in group)
                                {
                                    Console.WriteLine(vehicle);
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Enter the registration number of the vehicle you want to find: ");
                            var regNum = Console.ReadLine();
                            var vehicle = garageHandler.FindVehicle(regNum);

                            Console.WriteLine($"Found: {vehicle}");

                            break;
                        }
                    case 6:
                        {
                            Console.Write("Choose a property to filter on [1 - Color, 2 - Number of wheels]: ");
                            int menu = Helpers.GetInt();

                            IEnumerable<Vehicle> vehicles = new List<Vehicle>();
                            switch (menu)
                            {
                                case 1:
                                    {
                                        Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
                                        var color = (Color)Helpers.GetInt();
                                        vehicles = garageHandler.FindVehicle(v => v.Color == color);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("NumOfWheels: ");
                                        var wheels = Helpers.GetInt();
                                        vehicles = garageHandler.FindVehicle(v => v.NumOfWheels == wheels);
                                        break;
                                    }
                                default:
                                    break;
                            }

                            foreach (var vehicle in vehicles)
                            {
                                Console.WriteLine(vehicle);
                            }

                            break;
                        }
                    default:
                        Console.WriteLine("Please enter digits between 0-6 only. Try again!\n");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}