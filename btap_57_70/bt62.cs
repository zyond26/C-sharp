/*Bài tập 62. Đọc file trên vào 1 biến kiểu Dictionary
Viết 1 hàm C# static đọc vào 1 json file biết tên file và trả về 1 Dictionary. Viết bằng 2 cách.*/

// cách 1

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "C:\Users\zyond\OneDrive\Desktop\C-sharp\btap_57_70\dieu.json";
        var dictionary = ReadJsonFileToDictionary(filePath);
        // Do something with the dictionary
    }

    public static Dictionary<string, object> ReadJsonFileToDictionary(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        return dictionary;
    }
}

/*
// cách 2 

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "dieu.json";
        var dictionary = ReadJsonFileToDictionary(filePath);
        // Do something with the dictionary
    }

    public static Dictionary<string, object> ReadJsonFileToDictionary(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
        return dictionary;
    }
}
*/