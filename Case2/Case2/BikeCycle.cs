using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class BikeCycle : Viechle
    {
        public BikeCycle(string brand, string carType, int numberPlate) : base(brand, carType, numberPlate)
        {
            Brand = brand;
            CarType = carType;
            NumberPlate = numberPlate;
        }
    }
}
