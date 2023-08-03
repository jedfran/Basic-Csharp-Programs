using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
    {
    
    
    public class Employee : Person, IQuittable //Employee class inherits from Person class and inhert from interface IQuittable
        {
        public override void SayName()
            {
            Console.WriteLine("NAME: " + firstName + " " + lastName);
            }

        //Implemented Quit() Method
        public void Quit()
            {
            throw new NotImplementedException();
            }
        }
    }
