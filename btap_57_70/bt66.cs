/*Bài tập 66.Viết 1 hàm C# static đọc 1 file csv các số thực ,file csv có thể có header hoặc không có header biết tên file vào 1 mảng 2 chiều...
Hàm trả lại mảng...*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string filePathWithHeader = "data_with_header.csv";
        string filePathWithoutHeader = "data_without_header.csv";

        double[,] arrayWithHeader = ReadCsvFileTo2DArray(filePathWithHeader, true);
        double[,] arrayWithoutHeader = ReadCsvFileTo2DArray(filePathWithoutHeader, false);

        Console.WriteLine("Array from CSV with header:");
        Print2DArray(arrayWithHeader);

        Console.WriteLine("Array from CSV without header:");
        Print2DArray(arrayWithoutHeader);
    }

    public static double[,] ReadCsvFileTo2DArray(string filePath, bool hasHeader)
    {
        try
        {
            var lines = File.ReadAllLines(filePath).ToList();
            if (hasHeader && lines.Count > 0)
            {
                lines.RemoveAt(0); // Remove header line
            }

            int rows = lines.Count;
            int cols = lines[0].Split(',').Length;
            double[,] array = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(',');

                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = double.Parse(values[j]);
                }
            }

            return array;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }

    public static void Print2DArray(double[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
