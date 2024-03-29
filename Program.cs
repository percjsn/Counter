﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            var count = 0;

            Console.WriteLine("Numbers divisble by 3:");
            // Check 1 to 100 and print result
            for (int i = 1; i < 101; i++) // Loop through 1 to 100
            {
                var divisibleByThree = i % 3; //Divide each number by three
                if (divisibleByThree == 0) //If the divded number has no remainder continue
                {
                    Console.WriteLine(i); // Display Number Divisible by 3
                    count++; // Add to count
                }
            }
            Console.WriteLine("The count is: " + count); // Display the count
        }
    }
}
