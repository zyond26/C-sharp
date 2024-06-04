
/*Exercise 6: Write a C# program that prompts the user to enter a series of numbers. 
 * The program should calculate and display the sum of the positive numbers entered by the user. 
 * Use a while loop and a continue statement to skip negative numbers during the summation process.*/


using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double number;

            Console.WriteLine("Enter a series of numbers");

            while (true)
            {
                Console.Write("Enter a number ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative number detected. Skipping...");
                        continue;
                    }

                    sum += number;
                    Console.WriteLine("Current sum: " + (sum));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                }
            }

            Console.WriteLine("The sum of the positive numbers is: " + (sum));
        }
    }
}