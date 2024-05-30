using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array of integers :");
        string[] input = Console.ReadLine().Split();

        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        int maxValue = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }

        Console.WriteLine($"The maximum value in the array is: {maxValue}");
    }
}