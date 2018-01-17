using Garage.Enums;
using System;

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
                int menu;
                bool result = false;
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out menu))
                    {
                        Console.WriteLine("Your input is not an integer. Please enter digits only between 0-6. Try again!\n");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                
                switch (menu)
                {
                    case 0:
                        state = false;
                        break;
                    case 1:
                        result=garageHandler.AddVehicle(new Car { Color = Color.Black, RegistrationNum = "Car 001", NumOfWheels = 3, Length = 2, CylinderVolume = 1.6, FuelType = FuelType.Water, NumOfEngines = 1, NumOfSeats = 1 });
                        if(result == true)
                            Console.WriteLine("Your vehicle is added to the garage.\n");
                        else
                            Console.WriteLine("Unable to add your vehicle. Please try again.\n");
                        break;
                    case 2:
                        //garageHandler.RemoveVehicle();
                        break;
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Please enter digits between 0-6 only. Try again!\n");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}