/*Bài tập 18. Viết chương trình C# mode Console:
a. Viết hàm static đọc vào số thực 8 byte. Nhập sai thì nhập lại.
b. Trong lớp chứa hàm Main() khai báo biến số thực 8 byte x. Gọi hàm để đọc vào số x. Hiển thị giá trị căn bậc 2 của x.
*/

using System;
class Program
{
    static double ReadDouble()
    {
        double value;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(" nhập x: ");
        double x = ReadDouble();
        Console.WriteLine("Giá trị đã nhập: " + x);
        Console.WriteLine($"Căn bậc 2 của {x} là: {Math.Sqrt(x)}");
    }
}
