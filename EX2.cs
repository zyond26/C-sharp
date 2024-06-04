/*: Write a C# program that prompts the user to enter a day
of the week (1 for Monday, 2 for Tuesday, etc.) and displays the
corresponding name of the day. Use a switch statement to determine
the day and output the result */

using System;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day : ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}