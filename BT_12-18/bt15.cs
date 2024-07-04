/*Bài tập 15. Viết chương trình C# console, dịch ở mode Release 64bit, yêu cầu hiển thị tiếng Việt trong console:
+ Viết hàm static, đọc từ bàn phím số nguyên 1 byte, không dấu, nằm trong khoảng 2 đến 10, nếu nhập sai thì nhập lại.
+ Viết hàm static, đọc từ bàn phím 1 giá trị số thực 4 byte, nếu nhập sai thì nhập lại.
+ Viết hàm nhập vào 1 mảng số thực 4 byte biết số phần tử của mảng là số nguyên dương n cho trước.
+ Trong lớp chứa hàm Main(), khai báo số nguyên n 1 byte không dấu, gọi hàm để nhập giá trị của n, in ra màn hình giá trị được nhập.
+ Trong lớp chứa hàm Main(), khai báo mảng 1 chiều các số thực 4 byte a, và cấp phát để a gồm n phần tử.
+ Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím, in ra màn hình giá trị được nhập của mảng a.*/


using System;

class Program
{
    // Hàm đọc số nguyên 1 byte từ bàn phím, nằm trong khoảng 2 đến 10
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhap so nguyen 1 byte (2-10): ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            Console.WriteLine("invalid. vui long nhap lai .");
        }
    }

    // Hàm đọc số thực 4 byte từ bàn phím
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            Console.Write("Nhap so thuc 4 byte: ");
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
        }
    }

    // Hàm nhập mảng số thực 4 byte với số phần tử n
    static void ReadFloatArray(float[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = ReadFloat();
        }
    }

    static void Main()
    {
        // Đọc và in số nguyên n
        byte n = ReadByte();
        Console.WriteLine($"So nguyen n: {n}");

        // Khai báo và cấp phát mảng a
        float[] a = new float[n];

        // Đọc và in các phần tử của mảng a
        ReadFloatArray(a, n);
        Console.WriteLine("Mang a:");
        foreach (float x in a)
            Console.WriteLine(x);
    }
}