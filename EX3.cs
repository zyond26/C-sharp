/*Exercise 3: Write a C# program that prompts the user to enter a positive integer and then calculates the factorial of that number using a for loop. 
 * Display the factorial as the output.*/

using System;

public class FactorialCalculator
{
    public static void Main()
    {
        int n, factorial = 1;

        Console.Write("Enter a positive integer: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("The factorial of " + n +" is " + (factorial));
    }
}