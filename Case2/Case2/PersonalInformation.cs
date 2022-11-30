using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public abstract class PersonalInformation
    {
        public PersonalInformation(string firstName, string lastName, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        public abstract List<string> Search(string firstName, string lastName, List<Viechle> viechleList);
        public abstract void Search();
    }
}
