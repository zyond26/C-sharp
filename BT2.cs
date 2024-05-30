using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a real number:");
        double realNumber = Convert.ToDouble(Console.ReadLine());

        int intNumber = (int)realNumber;
        long longNumber = (long)realNumber;

        Console.WriteLine($"The number you entered is {realNumber}, as an int is {intNumber} and as a long is {longNumber}");
    }
}
