using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Enrollment
    {
        public Enrollment(Car carinfo, Customer customerinfo)
        {
            carInfo = carinfo;
            customerInfo = customerinfo;
        }
        public Enrollment()
        {
            Enrollments = new List<Enrollment>();
        }

        public Car carInfo { get; set; }
        public Customer customerInfo { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
