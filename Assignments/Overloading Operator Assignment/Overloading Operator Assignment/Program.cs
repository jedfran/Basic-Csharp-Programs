﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiate Two Objects
            Employee one = new Employee() { firstName = "Jedo", lastName = "Francisco", ID = 1 };
            Employee two = new Employee() { firstName = "John", lastName = "Doe", ID = 2 };

            //Comparing the two Employee Objects
            Console.WriteLine(one == two ? "They have the same ID" : "They have different ID");
            Console.ReadLine();
        }
    }
}
