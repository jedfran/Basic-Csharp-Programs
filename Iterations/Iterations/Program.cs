using System;
using System.Collections.Generic;


    class Program
    {
    static void Main(string[] args)
    {
        ////INTEGER ARRAY
        //    int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //    for (int i = 0; i < testScores.Length; i++)
        //    {
        //        if (testScores[i] > 85)
        //        {
        //            Console.WriteLine("Passing test scores: " + testScores[i]);
        //        }
        //    }
        //Console.ReadLine();

        ////STRING ARRAY
        //    string[] names = { "Jesse", "Eric", "Daniel", "Adam" };

        //    for (int j = 0; j < names.Length; j++)
        //    {
        //        //if (names[j] == "Jesse")
        //        //{
        //        //Console.WriteLine(names[j]);
        //        //}

        //        Console.WriteLine(names[j]);

        //    }
        //Console.ReadLine();

        ////LIST ITERATION
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(78);
        //testScores.Add(62);
        //testScores.Add(82);

        ////for each loop
        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //        Console.WriteLine("Passing Test Score: " + score);
        //}
        //Console.ReadLine();


        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    //if (name == "Jesse")
        //    //{
        //    //    Console.WriteLine(name);
        //    //}
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 24, 95 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
        Console.ReadLine();

       }
    }

