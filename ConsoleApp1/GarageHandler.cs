using Garage.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class GarageHandler
    {
        Garage<Vehicle> garage;

        public GarageHandler()
        {
            garage = new Garage<Vehicle>(GetCapacity());
        }

        public int GetCapacity()
        {
            Console.WriteLine("Enter an integer value for the capacity of the garage:");
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out int capacity)) // if tryParse false
                {
                    Console.WriteLine("The value you entered is not an integer.");
                }
                else // when true
                {
                    return capacity;
                }
            } while (true);
        }

        public bool AddVehicle(Vehicle veh)
        {
            if (garage.AddVehicle(veh))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveVehicle(Vehicle veh)
        {
            if (garage.RemoveVehicle(veh))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void ListOfVehicles()
        //{
        //    return  garage.ToList();
            

        //    int count = 0;
        //    Console.WriteLine("The list of vehicles is:");

        //    foreach (var vehicle in vehicleList)
        //    {
        //        if (vehicle != null)
        //        {
        //            Console.WriteLine(vehicle);
        //            count++;
        //        }
        //    }
        //    Console.WriteLine("The number of parked vehicles are " + count);
        //}

        //public void ListOfVehicleTypes()
        //{
        //    var vehicleTypes = garage.GroupBy(x => x.GetType()).Select(f=> new { };



        //    foreach (var group in vehicleTypes)
        //    {
        //        Console.WriteLine($"{group.Key.Name} ({group.Count()})");
        //        foreach (var vehicle in group)
        //        {
        //            Console.WriteLine(vehicle);
        //        }
        //    }
        //}

        //public T FindVehicle(String registrationNum)
        //{
        //    foreach (var vehicle in this)
        //    {
        //        if (vehicle.RegistrationNum == registrationNum)
        //            return vehicle;
        //        else
        //            return vehicle;
        //    }
        //}
    }
}
