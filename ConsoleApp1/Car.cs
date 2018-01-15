using Garage.Enums;
using System;

namespace Garage
{
    class Car : Vehicle
    {
        public Int32 NumOfEngines { get; set; }
        public FuelType FuelType { get; set; }
        public Int32 NumOfSeats { get; set; }
        public Double Length { get; set; }
        public Double CylinderVolume { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", {Length} m.";
        }
    }
}
