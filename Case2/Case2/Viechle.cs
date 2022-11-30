using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Viechle
    {
        public Viechle(string brand, string carType, int numberplate, string model, DateTime year, CarLogoEnum carEnum, string CarTypes)
        {
            NumberPlate = numberplate;
            Brand = brand;
            Model = model;
            Year = year;
            CarEnum = carEnum;
            CarTypes = carType;

        }
        public int NumberPlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public CarLogoEnum CarEnum { get; set; }
        public string CarTypes { get; set; }

        public List<Viechle> VichleList { get; set; }

        public Viechle()
        {
            VichleList = new List<Viechle>();
        }
    }
}
