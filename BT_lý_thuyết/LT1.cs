using System;
using System.IO;

class Program
{
    // 2: Khai báo biến chuỗi không đổi
    const string FilePath = "data.txt";

    //  3: Phương thức tạo tập tin
    static void CreateFile(string filePath)
    {
        // Sử dụng File.Create() để tạo tập tin mới
        using (FileStream fs = File.Create(filePath))
        {
            Console.WriteLine($"File '{filePath}' created.");
        }
    }

    //  4: Phương thức ghi nội dung vào tập tin
    static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine($"Content written to file '{filePath}'.");
    }

    // 5: Phương thức đọc nội dung từ tập tin
    static void ReadFromFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"Content of file '{filePath}':");
        Console.WriteLine(content);
    }

    // 6: Phương thức nối thêm nội dung vào tập tin
    static void AppendToFile(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
        Console.WriteLine($"Content appended to file '{filePath}'.");
    }

    //7: Phương thức xóa tập tin
    static void DeleteFile(string filePath)
    {
        File.Delete(filePath);
        Console.WriteLine($"File '{filePath}' deleted.");
    }
    static void Main(string[] args)
    {
        // 8: Gọi phương thức CreateFile
        CreateFile(FilePath);

        // 9: Gọi phương thức WriteToFile
        WriteToFile(FilePath, "This is the initial content.");

        // 10: Gọi phương thức ReadFromFile
        ReadFromFile(FilePath);

        // 11: Gọi phương thức AppendToFile
        AppendToFile(FilePath, "\nThis is the appended content.");

        // 12: Gọi lại phương thức ReadFromFile
        ReadFromFile(FilePath);

        // 13: Gọi phương thức DeleteFile
        DeleteFile(FilePath);

        // Chờ người dùng nhấn phím trước khi kết thúc chương trình
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
