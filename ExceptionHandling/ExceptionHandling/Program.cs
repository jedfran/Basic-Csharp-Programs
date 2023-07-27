using System;



    class Program
    {
        static void Main(string[] args)
        {

        //try/catch block is used when error happens throughout the code
        try
            {
            Console.WriteLine("Enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two numbers...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals: " + numberThree);
            Console.ReadLine();

            }
        catch (FormatException ex)
            {
            //Message when error appears
            Console.WriteLine("Please type a whole number.");
            return;
            }
        catch (DivideByZeroException ex)
            {
            
            Console.WriteLine("Please don't divide by zero.");
            }
        //General Exception
        catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
        //The finally will run no matter what, if the catch 'catches' something it will run,
        // if it doesn't catch anything it will still run.
        finally
            {
            Console.ReadLine();
            }
        Console.ReadLine();
        
        }
    }
