using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS
            // do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; //adds one per count

            }
            while (count < 5); //count will keep going until it reaches 5

            //while loop
            int count1 = 0;
            while (count1 < 3) //count1 will keep going until it reaches 3
            {
                Console.WriteLine("Counting Numbers");
                count1++;
            }
            Console.ReadLine();
        }
    }
}
