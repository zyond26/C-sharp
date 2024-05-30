using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a character:");
        char inputChar = Console.ReadKey().KeyChar;

        int asciiCode = (int)inputChar;

        Console.WriteLine($"\nThe character you entered is '{inputChar}', its ASCII code is {asciiCode}");
    }
}
