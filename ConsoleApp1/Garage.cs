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
        private T[] vehicles;
        public int Capacity { get; }
        
        public Garage(int capacity) {
            Capacity = capacity;
            vehicles = new T[capacity];
        }

        public bool AddVehicle(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveVehicle(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == vehicle)
                {
                    vehicles[i] = null;
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
                Console.WriteLine(vehicle);
                count++;
            }
            Console.WriteLine("The number of parked vehicles are " + count);
        }

        public void ListOfVehicleTypes()
        {
            foreach(var vehicle in this)
            {

                //if (Car.(this, vehicle))
                //{

                //}
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i]; //yield is MoveNext 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)vehicles).GetEnumerator();
        }
    }
}
