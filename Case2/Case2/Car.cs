using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Car : Viechle
    {
        public Car(string brand, string carTypes, int numberPlate, string model, DateTime year, CarLogoEnum carEnum) : base(brand, carTypes, numberPlate, model, year, carEnum)
        {
            Brand = brand;
            CarTypes = carTypes;
            NumberPlate = numberPlate;
            Model = model;
            Year = year;
            CarEnum = carEnum;
        }
    } 
}
