using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryandCatch_Assignment
    {
    class Program
        {
        static void Main(string[] args)
            {
            //Created a list of random numbers
            List<int> randomNums = new List<int> { 72, 34, 17, 35, 29, 50 };
            Console.WriteLine("72, 34, 17, 35, 29, 50");
            bool numValid = false;
            while (!numValid)
                {
                try
                    {
                    
                    Console.WriteLine("Enter a number to divide each number on the list: ");
                    //Taking the number the user entered
                    float dividingNumber = float.Parse(Console.ReadLine());
                    //When user enters 0, which you cannot divide with
                    if (dividingNumber == 0)
                        {
                        Console.WriteLine("Please enter a number other than 0");
                        }

                    else
                        {
                        //Creating a loop to divide all the numbers with the number the user gave
                        foreach (float num in randomNums)
                            {
                            float answer = num / dividingNumber;
                            Console.WriteLine("The Answers Are: " + answer);
                            }
                        //Stops the loop
                        numValid = true;
                        }

                    }
                //A catch for when the user enters anything other than number
                catch (FormatException ex)
                    {
                    Console.WriteLine("Please enter a whole number!");

                    }
                }

            Console.WriteLine("You are out of the try and catch block.");
            Console.ReadLine();
            }
            
        
       
        }
    }
