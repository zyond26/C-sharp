/*Bài tập 12. Viết chương trình C# console, dịch ở mode Release 64bit, yêu cầu hiển thị tiếng Việt trong console:
-	Viết hàm C#, hàm static, đọc từ bàn phím số nguyên 2 byte, không dấu, nếu nhập sai thì nhập lại.
-	Trong lớp chứa hàm Main(), khai báo số nguyên n 2 byte không dấu, gọi hàm để nhập giá trị của n, in ra màn hình giá trị được nhập.
-	Tính tổng bình phương các số từ 1 đến n , in ra console giá trị tính được.
*/


using System;
class Program
{
    static ushort ReadUshort()
    {
        Console.WriteLine("nhap value: ");
        ushort value;
        while (true)
        {
            if (ushort.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ushort n = ReadUshort();
        Console.WriteLine($"Giá trị đã nhập: {n}");

        ulong sum = 0;
        for (ushort i = 1; i <= n; i++)
            sum += (ulong)i * i;

        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sum}");
    }
}