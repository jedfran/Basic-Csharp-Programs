using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Casting Example (string -> int)
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();


            //Different Data Types
            bool isStudying = false;

            byte hoursWorked = 42;

            sbyte currentTemperature = -21;

            char randomLetter = 'X';

            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; // 'm' doesn't mean million

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f; // 'f' so computer knows it is a float

            short temperatureOnMars = -341;

            string myName = "Jedo";

            //Console.Write(questionMark);
            //Console.ReadLine();

            //Casting Example (int -> string)
            int currentAge = 20;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
