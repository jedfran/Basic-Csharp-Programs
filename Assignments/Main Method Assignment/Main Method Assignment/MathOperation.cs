using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
    {
    public class MathOperation
        {

        //Method One: Addition
        public int MathOP (int number)
            {
            return number + 10;
            }

        //Method Two: Takes in decimal returns to integer
        public int MathOP (decimal number)
            {
            //Converting decimal to an integer
            int intNum = Convert.ToInt32(number);
            return intNum * 5;
            }

        //Method Three: Takes in string returns to integer

        public int MathOP (string number)
            {
            //Converting string to integer
            int intNum = Convert.ToInt32(number);
            return intNum - 2;

            }
            
        }
    }
