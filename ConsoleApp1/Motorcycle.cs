using Garage.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Motorcycle : Vehicle
    {
        public Int32 NumOfEngines { get; set; }
        public FuelType FuelType { get; set; }
        public Int32 NumOfSeats { get; set; }
        public Double Length { get; set; }
    }
}
