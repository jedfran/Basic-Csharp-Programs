using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryandCatch_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;

            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    //Ask for their age
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    //Exception if user eners 0 or negative numbers
                    if (age == 0 || age < 0)
                    {
                        throw new WrongAge();
                    }
                    //Displays the year user was born
                    int yearOfBirth = today.Year - age;
                    Console.WriteLine("You are born in: " + yearOfBirth);
                    validAnswer = true;
                    Console.ReadLine();
                    return;

                }
                catch (WrongAge)
                {
                    Console.Write("Please enter the appropraite age, no negatives or 0s");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong!");
                    Console.ReadLine();
                    return;
                }
            }
            
            
            
        }
    }
}
