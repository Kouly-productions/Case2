using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Mechanic : PersonalInformation
    {
        public Mechanic(string firstName, string lastName, int phoneNumber, CarLogoEnum mechanicType) : base(firstName, lastName, phoneNumber)
        {
            MechanicType = mechanicType;
        }



        public CarLogoEnum MechanicType { get; set; }

        public override List<string> Search(string firstName, string lastName, List<Viechle> viechleList)
        {
            throw new NotImplementedException();
        }

        public override void Search()
        {
            throw new NotImplementedException();
        }
    }
}
