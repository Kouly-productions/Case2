using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Customer : PersonalInformation
    {
        public Customer(string firstName, string lastName, int phoneNumber) : base(firstName, lastName, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override List<string> Search(string firstName, string lastName, List<Viechle> viechleList)
        {
            List<string> cars = new List<string>();

            return cars;
        }

        public override void Search()
        {
            throw new NotImplementedException();
        }
    }
}
