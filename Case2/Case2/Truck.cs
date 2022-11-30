using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Truck : Viechle
    {
        public Truck(string brand, string carType, int numberplate, string Model, DateTime year, CarLogoEnum carEnum, string CarType) : base ()
        {
            Brand = brand;
            CarType = carType;
            NumberPlate = numberplate;
            Year = year;
            CarEnum = carEnum;
        }
    }
}
