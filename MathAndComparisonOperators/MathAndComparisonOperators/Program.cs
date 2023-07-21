using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Math Operators

            //Addition
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //Subraction
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //Multiplication
            //int product = 10 * 5;
            //Console.WriteLine("Ten multiply by Five = " + product.ToString());
            //Console.ReadLine();

            //Division
            //int quotient = 10 / 5;
            //Console.WriteLine("Ten divided by Five = " + quotient.ToString());
            //Console.ReadLine();

            //Remainders (Modulus Operator)
            //int remainder = 11 % 2;
            //Console.WriteLine("11 divided 2 has a remainder of: " + remainder.ToString());
            //Console.ReadLine();


            //Comparison Operators

            //Boolean
            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int CurrentTemperature = 70;

            //bool isWarm = CurrentTemperature >= roomTemperature;
            //bool isWarm = CurrentTemperature != roomTemperature;
            //bool isWarm = CurrentTemperature == roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //-------------------------------------------------------------//

            //Multiply 50 and returns results
            Console.WriteLine("Enter a number and I multiply by 50");
            string multiplyFifty = Console.ReadLine();
            int multiplyFiftyNum = Convert.ToInt32(multiplyFifty) * 50;
            Console.WriteLine(multiplyFifty + " multiply by 50 is = " + multiplyFiftyNum);
           
            //Adds 25 and returns results
            Console.WriteLine("Enter a number and I add 25");
            string addition1 = Console.ReadLine();
            int addition1Num = Convert.ToInt32(addition1) + 25;
            Console.WriteLine(addition1 + " plus 25 is = " + addition1Num);

            //Divides by 12.5 and returns results
            Console.WriteLine("Enter a number and I divide by 12.5");
            string divide1 = Console.ReadLine();
            double divide1Num = Convert.ToDouble(divide1) / 12.5;
            Console.WriteLine(divide1 + " divided by 12.5 is = " + divide1Num);
            

            //Divides by 7 and shows the ramainder as results
            Console.WriteLine("Enter a number and I will divide by 7 and give you the remainder");
            string remainder1 = Console.ReadLine();
            int remainder1Num = Convert.ToInt32(remainder1) % 7;
            Console.WriteLine("The remainder is = " + remainder1Num);
            Console.ReadLine();


        }
    }
}
