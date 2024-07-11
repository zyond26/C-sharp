/*Bài tập 65. Viết 1 hàm C# static ghi 1 Dictionary kiểu Value là số thực 8byte ra  1 file csv có header biết tên file.
Gọi hàm trong hàm Main().*/


using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        var dictionary = new Dictionary<string, double>
        {
            { "Key1", 1.1 },
            { "Key2", 2.2 },
            { "Key3", 3.3 }
        };

        string filePath = "dieu.csv";
        WriteDictionaryToCsvFile(filePath, dictionary);
        Console.WriteLine("File written successfully.");
    }

    public static void WriteDictionaryToCsvFile(string filePath, Dictionary<string, double> dictionary)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the header
                writer.WriteLine("Key,Value");

                // Write the dictionary contents
                foreach (var kvp in dictionary)
                {
                    writer.WriteLine($"{kvp.Key},{kvp.Value}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
