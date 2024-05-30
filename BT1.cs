using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();

            int integerNumber;
            if (int.TryParse(input, out integerNumber))
            {
                double doubleNumber = (double)integerNumber;

                Console.WriteLine($"The number you entered is {integerNumber} and as a double is {doubleNumber}");
            }
            else
            {
                Console.WriteLine("The input is not a valid integer.");
            }
        }
    }
}
