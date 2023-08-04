using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created two objects of Number
            Number num1 = new Number() { Amount = 200 };
            Number num2 = num1;
            num2.Amount = 400;//if it werent for the "struct" this would change the Amount to 400

            Console.WriteLine(num1.Amount);
            Console.ReadLine();

        }
    }
}
