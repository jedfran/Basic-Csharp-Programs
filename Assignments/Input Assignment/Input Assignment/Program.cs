using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to enter a number
            Console.WriteLine("Please enter a number!");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            //Logs the number into a text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Jedo Francisco\logs\input.txt",true))
            {
                file.WriteLine(inputNum);
            }

            //Store the number in a text file 
            string text = (File.ReadAllText(@"C:\Users\Jedo Francisco\logs\input.txt"));

            //Prints the number to the user
            Console.WriteLine("Your number is: {0}", text);
            Console.ReadLine();
        }
    }
}
