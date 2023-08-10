using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Zoo!");
            //create a constant variable
            const string animal = "You want to see... ";
            const string amount = "The amount of animal you like to see is... ";
            Console.WriteLine("Please enter an animal or the amount you would like to see.");
            //variable using keyword "var"
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(amount);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(animal);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
                
            

        }
    }
}
