/*Bài tập 13. Viết chương trình C# console, dịch ở mode Release 64bit, yêu cầu hiển thị tiếng Việt trong console:
-	Viết hàm static, đọc từ bàn phím số nguyên 1 byte, không dấu, nằm trong khoảng 2 đến 10, nếu nhập sai thì nhập lại.
-	Trong lớp chứa hàm Main(), khai báo số nguyên n 1 byte không dấu, gọi hàm để nhập giá trị của n, in ra màn hình giá trị được nhập*/

using System;
class Program
{
    static byte ReadByte(byte min, byte max)
    {
        Console.WriteLine("nhập value: ");
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            else
                Console.WriteLine($"Giá trị không hợp lệ. Vui lòng nhập lại một số trong khoảng từ {min} đến {max}.");
        }
    }

    static void Main()
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Đọc một giá trị byte trong khoảng từ 2 đến 10
        byte n = ReadByte(2, 10);

        // In giá trị đã nhập
        Console.WriteLine($"Giá trị đã nhập: {n}");
    }
}