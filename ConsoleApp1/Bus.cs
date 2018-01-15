using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Bus : Vehicle
    {
        public Int32 NumOfEngines { get; set; }
        public String FuelType { get; set; }
        public Int32 NumOfSeats { get; set; }
        public Double Length { get; set; }
        public Double CylinderVolume { get; set; }
    }
}
