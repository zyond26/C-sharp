/*Bài tập 63. Viết 1 hàm C# static ghi 1 Dictionary ra file json biết tên file.Hàm trả lại giá trị kiểu gì? 
Viết bằng 2 cách.Gọi hàm trong Main() để kiểm tra.*/



// cách 1 :
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        var dictionary = new Dictionary<string, object>
        {
            { "Key1", "Value1" },
            { "Key2", 12345 },
            { "Key3", true }
        };

        string filePath = "dieu.json";
        bool isSuccess = WriteDictionaryToJsonFile(filePath, dictionary);
        Console.WriteLine(isSuccess ? "File written successfully using System.Text.Json." : "Failed to write file using System.Text.Json.");
    }

    public static bool WriteDictionaryToJsonFile(string filePath, Dictionary<string, object> dictionary)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(dictionary);
            File.WriteAllText(filePath, jsonString);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}



// cách 2: 

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        var dictionary = new Dictionary<string, object>
        {
            { "Key1", "Value1" },
            { "Key2", 12345 },
            { "Key3", true }
        };

        string filePath = "dieu.json";
        bool isSuccess = WriteDictionaryToJsonFile(filePath, dictionary);
        Console.WriteLine(isSuccess ? "File written successfully using Newtonsoft.Json." : "Failed to write file using Newtonsoft.Json.");
    }

    public static bool WriteDictionaryToJsonFile(string filePath, Dictionary<string, object> dictionary)
    {
        try
        {
            string jsonString = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
