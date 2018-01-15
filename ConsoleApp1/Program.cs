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

            var garage = new Garage<Vehicle>(10);
            garage.AddVehicle(new Car { Color = Color.Black, RegistrationNum = "Car 001", NumOfWheels = 3, Length = 2, CylinderVolume = 1.6, FuelType = FuelType.Water, NumOfEngines = 1, NumOfSeats = 1 });
            garage.AddVehicle(new Car { Color = Color.White, RegistrationNum = "Car 002", NumOfWheels = 4, Length = 3.53, CylinderVolume = 2, FuelType = FuelType.Petrol, NumOfEngines = 1, NumOfSeats = 4 });
            garage.AddVehicle(new Car { Color = Color.Red, RegistrationNum = "Car 003", NumOfWheels = 4, Length = 4.5, CylinderVolume = 1.2, FuelType = FuelType.Electricity, NumOfEngines = 1, NumOfSeats = 5 });
            
            garage.AddVehicle(new Bus { Color = Color.Silver, RegistrationNum = "Bus 003", NumOfWheels = 6, Length = 4.5, CylinderVolume = 1.2, NumOfEngines = 1, NumOfSeats = 30, FuelType = FuelType.Desil });

            garage.ListOfVehicleTypes();

            Console.ReadKey();
        }
    }
}