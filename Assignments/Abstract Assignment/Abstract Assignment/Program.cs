using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
    {
    class Program
        {
        static void Main(string[] args)
            {
            //Instantiate and give firstName and lastName values
            Employee demo = new Employee() { firstName = "Sample", lastName = "Student" };

            //Call the method SayName()
            demo.SayName();
            Console.ReadLine();
            }
        }
    }
