
/*Exercise 5: Write a C# program that prompts the user to guess a secret number between 1 and 100. 
 * The program should generate a random secret number and provide hints to the user (higher or lower) until they correctly guess the number.
 * Use a while loop and a break statement to control the guessing process.*/

using System;

public class EX5
{
    public static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess;

        Console.WriteLine("Enter a number between 1 and 100.Guess what it is?");

        while (true)
        {
            Console.Write("Your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Correct! The secret number was " + (secretNumber));
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}
