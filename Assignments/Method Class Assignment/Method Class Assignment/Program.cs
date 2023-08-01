using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
    {
    class Program
        {
        static void Main(string[] args)
            {

            //Instantiate class "TwoIntegers"
            TwoIntegers number = new TwoIntegers();

            Console.WriteLine("Enter two numbers: ");
            Console.WriteLine("Number 1 (+10): ");
            //Asking for user's first number
            int number1 = Convert.ToInt32(Console.ReadLine());
            //Asking for user's second number
            Console.WriteLine("Number 2 (Displaying number): ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Calling two numbers and speicifying the parameters by name
            //number.Method(11, 5);
            number.Method(number1, number2);
            Console.ReadLine();

            }
        }
    }
