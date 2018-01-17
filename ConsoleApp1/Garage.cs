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
            return _vehicles.Where(x => x != null).GetEnumerator();
        }
    }
}
