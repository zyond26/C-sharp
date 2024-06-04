/*Exercise 1 : Write a C# program that asks the user to enter a number and checks if it is positive, negative, or zero. 
  Based on the input, display an appropriate message.
*/
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number:");

        string input = Console.ReadLine();
        double number;
        bool isValid = double.TryParse(input, out number);

        if (isValid)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid. Please enter a valid number.");
        }
    }
}
