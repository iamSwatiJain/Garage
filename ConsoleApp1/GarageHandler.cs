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
            return garage.AddVehicle(veh);
        }

        public bool RemoveVehicle(String registrationNum)
        {
            var veh = FindVehicle(registrationNum);
            return garage.RemoveVehicle(veh);
        }

        public IList<Vehicle> ListOfVehicles()
        {
            return garage.ToList();
        }

        public IEnumerable<IGrouping<Type, Vehicle>> ListOfVehicleTypes()
        {
            return garage.GroupBy(x => x.GetType());
        }

        public Vehicle FindVehicle(String registrationNum)
        {
            return garage.FirstOrDefault(x => x.RegistrationNum == registrationNum);
        }

        internal IEnumerable<Vehicle> FindVehicle(Func<Vehicle, Boolean> p)
        {
            return garage.Where(p);
        }
    }
}
