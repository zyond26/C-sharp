using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //  a: Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực kích thước 4 byte
        Console.Write("Nhap mang so thuc:  ");
        string[] input = Console.ReadLine().Split();
        float[] numbers = Array.ConvertAll(input, float.Parse);

        float max = float.MinValue;
        float min = float.MaxValue;

        foreach (float num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }
        Console.WriteLine($"gia tri lon nhat: {max}");
        Console.WriteLine($"gia tri nho nhat: {min}");
        Console.WriteLine();

        //  b: Tính tổng các số trong mảng số thực kích thước 4 byte
        Console.WriteLine("nhap so luong ptu mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] B = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap phan tu thu " + (i + 1) + ": ");
            B[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += B[i];
        }
        Console.WriteLine("tong cac so trong mang: " + sum);
    }
}
