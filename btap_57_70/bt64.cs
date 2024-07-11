/*Bài tập 64.Viết 1 hàm C# static, 
ghi 1 mảng 2 chiều các số thực 4 byte ra 1 file csv không có header biết tên file.Gọi hàm trong hàm Main().*/


using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        float[,] array = {
            { 1.1f, 2.2f, 3.3f },
            { 4.4f, 5.5f, 6.6f },
            { 7.7f, 8.8f, 9.9f }
        };

        string filePath = "output.csv";
        Write2DArrayToCsvFile(filePath, array);
        Console.WriteLine("File written successfully.");
    }

    public static void Write2DArrayToCsvFile(string filePath, float[,] array)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(array[i, j]);
                        if (j < cols - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
