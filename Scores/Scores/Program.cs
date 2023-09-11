using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Jedo Francisco\OneDrive\Desktop\School\C#\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            
            double tScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student score. \tAverage Score: " + avgScore);

            
            Console.WriteLine("\n\nPlease any key to exit...");
            Console.ReadKey();
        }
    }
}
