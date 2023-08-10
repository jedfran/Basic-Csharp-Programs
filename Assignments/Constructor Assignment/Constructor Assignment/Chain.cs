using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Chain
    {
        //List of Properties
        public string Animal { get; set; }
        public float Amount { get; set; }

        //If both animal and amount is provided
        public Chain(string animal, float amount)
        {
            Animal = animal;
            Amount = amount;
        }

        //If only animal is provided
        public Chain(string animal) : this(animal, 2)
        {
            Console.WriteLine("{0} firsts, and we are seeing {1} of them!", animal, 2);
        }

        //If amount of animal is only provided
        public Chain(float amount) : this("Lion", amount)
        {
            Console.WriteLine("{0} and we are seeing {1} first!", amount , "Lions"); ;
        }
    }
}
