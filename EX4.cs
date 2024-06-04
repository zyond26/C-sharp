
/*Exercise 4: Write a C# program that uses nested loops to display a pattern of asterisks. 
 * The number of rows and columns in the pattern should be determined by the user input.*/

using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            Console.WriteLine("enter rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("enter columns: ");
            columns = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}