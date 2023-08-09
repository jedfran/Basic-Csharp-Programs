using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints Current Date Time 
            Console.WriteLine(DateTime.Now);
            //Ask for user to enter a number
            Console.WriteLine("Please Enter a number: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            //Prints to the console the exact time it will be in X hours
            Console.Write("{0} + {1} hours will be {2}", DateTime.Now, hour, DateTime.Now.AddHours(hour));
            Console.ReadLine();

        }
    }
}
