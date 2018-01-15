using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] _vehicles;
        public int Capacity { get; }
        
        public Garage(int capacity) {
            Capacity = capacity;
            _vehicles = new T[capacity];
        }

        public bool AddVehicle(T vehicle)
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] == null)
                {
                    _vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveVehicle(T vehicle)
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] == vehicle)
                {
                    _vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void ListOfVehicles()
        {
            int count = 0;
            Console.WriteLine("The list of vehicles is:");

            foreach (var vehicle in this)
            {
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle);
                    count++;
                }
            }
            Console.WriteLine("The number of parked vehicles are " + count);
        }

        public void ListOfVehicleTypes()
        {
            var vehicleTypes = this.Where(x => x != null).GroupBy(x => x.GetType());

            foreach (var group in vehicleTypes)
            {
                Console.WriteLine($"{group.Key.Name} ({group.Count()})");
                foreach (var vehicle in group)
                {
                    Console.WriteLine(vehicle);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] != null)
                {
                    yield return _vehicles[i]; //yield is MoveNext 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _vehicles.GetEnumerator();
        }
    }
}
