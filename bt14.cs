/*Bài tập 14. Viết chương trình C# console, dịch ở mode Release 64bit, yêu cầu hiển thị tiếng Việt trong console:
-Viết hàm static, đọc từ bàn phím 1 giá trị số thực 4 byte, nếu nhập sai thì nhập lại.
-Trong lớp chứa hàm Main(), khai báo số thực x 4 byte , gọi hàm để nhập giá trị của x, in ra màn hình giá trị được nhập
*/


using System;

class Program
{
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại một số thực.");
        }
    }

    static void Main()
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Đọc một giá trị số thực 4 byte
        float x = ReadFloat();

        // In giá trị đã nhập
        Console.WriteLine($"Giá trị đã nhập: {x}");
    }
}