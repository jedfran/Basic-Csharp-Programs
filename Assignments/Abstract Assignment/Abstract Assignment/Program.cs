using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
    {
    public class Program
        {

        
        static void Main(string[] args)
            {
            //Instantiate Interface with Class
            IQuittable quitter = new Employee();

            //Instantiate and give firstName and lastName values
            Employee demo = new Employee() { firstName = "Sample", lastName = "Student" };

            //Call the method SayName()
            demo.SayName();
            

            //Method Quit() after instantiating interface(IQuittable) with class(Employee);
            quitter.Quit();
            Console.ReadLine();
            }
        }
    }
