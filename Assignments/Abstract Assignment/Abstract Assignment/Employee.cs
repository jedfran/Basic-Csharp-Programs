using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
    {
    public class Employee : Person //Employee class inherits from Person class
        {
        public override void SayName()
            {
            Console.WriteLine("NAME: " + firstName + " " + lastName);
            }
        }
    }
