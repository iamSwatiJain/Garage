using Garage.Enums;
using System;

namespace Garage
{
    public abstract class Vehicle
    {
        public String RegistrationNum { get; set; }
        public Color Color { get; set; }
        public Int32 NumOfWheels { get; set; }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} [{RegistrationNum}] with {NumOfWheels} wheels";
        }
    }
}
