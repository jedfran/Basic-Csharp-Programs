using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    class Program
    {
        //Enums for the days of the week
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    
        static void Main(string[] args)
        {
            bool isValid = false;
            while(!isValid)
            {
                try
                {
                    //Ask for user to enter the day of the week
                    Console.WriteLine("Enter a day of the week: ");
                    string userInput = Console.ReadLine();
                    //Assign the value to a variable
                    Days day = (Days)Enum.Parse(typeof(Days), userInput);
                    Console.WriteLine("Thank you for telling the truth.");
                    Console.ReadLine();
                    isValid = true;

                }
                
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please dont lie, try again!");
                }
            }
            

            
        }

    }
}
