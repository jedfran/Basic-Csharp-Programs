using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator_Assignment
{
    public class Employee
    {
        //List of properties( ID, firstName and lastName)
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


        //Overloading operator "==" and "!="

        public static bool operator ==(Employee one, Employee two)
        {
            if (one.ID.Equals(two.ID))
                return true;
            else
                return false;

        }
        public static bool operator !=(Employee one, Employee two)
        {
            if (one.ID.Equals(two.ID))
                return false;
            else
                return true;
        }

    }
}
