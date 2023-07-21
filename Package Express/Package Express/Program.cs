using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Asking for weight of package
            Console.WriteLine("Please enter weight of the package.");
            string packageWeight = Console.ReadLine();
            int packageWeightNum = Convert.ToInt32(packageWeight);
            //Send Error if package weight is greater than or equal to 50 (too heavy)
                if (packageWeightNum >= 50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                }

            //Asking for dimensions of package (width,height and length)
            //Width
            Console.WriteLine("Please enter width of the package.");
            string packageWidth = Console.ReadLine();
            int packageWidthNum = Convert.ToInt32(packageWidth);
            //Height
            Console.WriteLine("Please enter height of the package.");
            string packageHeight = Console.ReadLine();
            int packageHeightNum = Convert.ToInt32(packageHeight);
            //Length
            Console.WriteLine("Please enter length of the package.");
            string packageLength = Console.ReadLine();
            int packageLengthNum = Convert.ToInt32(packageLength);
            //Total Dimension (Width + Height + Length)
            int totalDimension = packageWidthNum + packageHeightNum + packageLengthNum;
                //Send Error if total dimension is equal to 50 (too big)
                if (totalDimension >= 50)
                {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                }

            //Multiplying each dimension + weight of package to get the price
            //(width * height * length * weight)
            //Converting int to decimal and dividing by 100 after to get the total price of the package
            decimal packagePrice = Convert.ToDecimal(packageWidthNum * packageHeightNum * packageLengthNum * packageWeightNum) / 100;
            Console.WriteLine("Your estimated total for shipping this packing is: $" + packagePrice);
            Console.ReadLine();

        }
    }
}
