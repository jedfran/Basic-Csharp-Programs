using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()
    {
        ////ARRAY
        ////integer array
        //int[] numArray = new int[5]; //the length of the array is 5
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////easier way to set up an array
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        ////even faster way of creating an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////changing the value of a value in the array
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        ////LISTS
        List<int> intList = new List<int>();
        intList.Add(4);//index 0 value 4
        intList.Add(10); //index 1 value 10
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Jedo");

        Console.WriteLine(stringList[0]);
        Console.ReadLine();


    }
    }

