using Garage.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class VehicleFactory
    {
        public Vehicle NewVehicle()
        {
            Console.WriteLine("1: Airplane");
            Console.WriteLine("2: Motorcycle");
            Console.WriteLine("3: Car");
            Console.WriteLine("4: Bus");
            Console.WriteLine("5: Boat");
            Console.WriteLine("0: Back to main Menu");

            switch (Helpers.GetMenuChoice(5))
            {
                case 1:
                    return CreateAirplane();
                case 2:
                    return CreateMotorcycle();
                case 3:
                    return CreateCar();
                case 4:
                    return CreateBus();
                case 5:
                    return CreateBoat();
                default:
                    return null;
            }
        }

        private Vehicle CreateAirplane()
        {
            Console.Write("Registration Number: ");
            var regNr = Console.ReadLine();

            Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
            var color = (Color)Helpers.GetMenuChoice(3);

            Console.Write("Fuel [0 - Petrol, 1 - Desiel, 2 - Electric, 3 - Hydrogen]: ");
            var fuel = (FuelType)Helpers.GetMenuChoice(3);

            Console.Write("Length: ");
            var length = Helpers.GetDouble();

            Console.Write("NumOfEngines: ");
            var numOfEngines = Helpers.GetInt();

            Console.Write("NumOfSeats: ");
            var numOfSeats = Helpers.GetInt();

            Console.Write("NumOfWheels: ");
            var numOfWheels = Helpers.GetInt();

            return new Airplane
            {
                RegistrationNum = regNr,
                Color = color,
                FuelType = fuel,
                Length = length,
                NumOfEngines = numOfEngines,
                NumOfSeats = numOfSeats,
                NumOfWheels = numOfWheels
            };
        }

        private Vehicle CreateBus()
        {
            Console.Write("Registration Number: ");
            var regNr = Console.ReadLine();

            Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
            var color = (Color)Helpers.GetMenuChoice(3);

            Console.Write("Fuel [0 - Petrol, 1 - Desiel, 2 - Electric, 3 - Hydrogen]: ");
            var fuel = (FuelType)Helpers.GetMenuChoice(3);

            Console.Write("Length: ");
            var length = Helpers.GetDouble();

            Console.Write("NumOfEngines: ");
            var numOfEngines = Helpers.GetInt();

            Console.Write("NumOfSeats: ");
            var numOfSeats = Helpers.GetInt();

            Console.Write("NumOfWheels: ");
            var numOfWheels = Helpers.GetInt();

            Console.Write("CylinderVolume: ");
            var cylinderVolume = Helpers.GetDouble();

            return new Bus
            {
                RegistrationNum = regNr,
                Color = color,
                FuelType = fuel,
                Length = length,
                NumOfEngines = numOfEngines,
                NumOfSeats = numOfSeats,
                NumOfWheels = numOfWheels,
                CylinderVolume = cylinderVolume
            };
        }

        private Vehicle CreateCar()
        {
            Console.Write("Registration Number: ");
            var regNr = Console.ReadLine();

            Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
            var color = (Color)Helpers.GetMenuChoice(3);

            Console.Write("Fuel [0 - Petrol, 1 - Desiel, 2 - Electric, 3 - Hydrogen]: ");
            var fuel = (FuelType)Helpers.GetMenuChoice(3);

            Console.Write("Length: ");
            var length = Helpers.GetDouble();

            Console.Write("NumOfEngines: ");
            var numOfEngines = Helpers.GetInt();

            Console.Write("NumOfSeats: ");
            var numOfSeats = Helpers.GetInt();

            Console.Write("NumOfWheels: ");
            var numOfWheels = Helpers.GetInt();

            Console.Write("CylinderVolume: ");
            var cylinderVolume = Helpers.GetDouble();

            return new Car
            {
                RegistrationNum = regNr,
                Color = color,
                FuelType = fuel,
                Length = length,
                NumOfEngines = numOfEngines,
                NumOfSeats = numOfSeats,
                NumOfWheels = numOfWheels,
                CylinderVolume = cylinderVolume
            };
        }

        private Vehicle CreateBoat()
        {
            Console.Write("Registration Number: ");
            var regNr = Console.ReadLine();

            Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
            var color = (Color)Helpers.GetMenuChoice(3);

            Console.Write("Fuel [0 - Petrol, 1 - Desiel, 2 - Electric, 3 - Hydrogen]: ");
            var fuel = (FuelType)Helpers.GetMenuChoice(3);

            Console.Write("Length: ");
            var length = Helpers.GetDouble();

            Console.Write("NumOfEngines: ");
            var numOfEngines = Helpers.GetInt();

            Console.Write("NumOfSeats: ");
            var numOfSeats = Helpers.GetInt();

            Console.Write("NumOfWheels: ");
            var numOfWheels = Helpers.GetInt();

            Console.Write("CylinderVolume: ");
            var cylinderVolume = Helpers.GetDouble();

            return new Boat
            {
                RegistrationNum = regNr,
                Color = color,
                FuelType = fuel,
                Length = length,
                NumOfEngines = numOfEngines,
                NumOfSeats = numOfSeats,
                NumOfWheels = numOfWheels,
                CylinderVolume = cylinderVolume
            };
        }

        private Vehicle CreateMotorcycle()
        {
            Console.Write("Registration Number: ");
            var regNr = Console.ReadLine();

            Console.Write("Color [0 - Black, 1 - White, 2 - Red, 3 - Blue]: ");
            var color = (Color)Helpers.GetMenuChoice(3);

            Console.Write("Fuel [0 - Petrol, 1 - Desiel, 2 - Electric, 3 - Hydrogen]: ");
            var fuel = (FuelType)Helpers.GetMenuChoice(3);

            Console.Write("Length: ");
            var length = Helpers.GetDouble();

            Console.Write("NumOfEngines: ");
            var numOfEngines = Helpers.GetInt();

            Console.Write("NumOfSeats: ");
            var numOfSeats = Helpers.GetInt();

            Console.Write("NumOfWheels: ");
            var numOfWheels = Helpers.GetInt();

            return new Motorcycle
            {
                RegistrationNum = regNr,
                Color = color,
                FuelType = fuel,
                Length = length,
                NumOfEngines = numOfEngines,
                NumOfSeats = numOfSeats,
                NumOfWheels = numOfWheels
            };
        }


    }
}
