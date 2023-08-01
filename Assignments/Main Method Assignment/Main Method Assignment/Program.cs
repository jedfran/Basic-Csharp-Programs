using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
    {
    class Program
        {
        static void Main(string[] args)
            {

            // Instantiate MathOperation class
            MathOperation math1 = new MathOperation();

            //Integer 
            Console.WriteLine("Enter a whole number and I will add 10 to it: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANSWER: " + math1.MathOP(num1));

            //Decimal to Integer
            Console.WriteLine("Enter a decimal number and I will multiply it by 5 : ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ANSWER: " + math1.MathOP(num2));

            //String to Integer
            Console.WriteLine("Enter a whole number and I will minus 2 to it: ");
            string num3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ANSWER: " + math1.MathOP(num3));
            Console.ReadLine();

            }
        }
    }
