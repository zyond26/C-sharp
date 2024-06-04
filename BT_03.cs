using System;

class Program
{
    static void Main()
    {
        // a: Tính tổng các số trong mảng số nguyên không dấu kích thước 2 byte
        Console.Write("nhap mang so nguyen khong dau: ");
        string[] inputA = Console.ReadLine().Split();
        ushort[] numbersA = Array.ConvertAll(inputA, s => Convert.ToUInt16(s));

        uint sumUnsigned = 0;

        foreach (ushort num in numbersA)
        {
            sumUnsigned += num;
        }

        Console.WriteLine($"Tong cac so khong dau: {sumUnsigned}");
        Console.WriteLine();

        // b: Tính tổng các số trong mảng số nguyên có dấu kích thước 2 byte
        Console.Write("Nhap mang so nguyen co dau:  ");
        string[] inputB = Console.ReadLine().Split();
        short[] numbersB = Array.ConvertAll(inputB, s => Convert.ToInt16(s));

        int sumSigned = 0;

        foreach (short num in numbersB)
        {
            sumSigned += num;
        }

        Console.WriteLine($"Tong cac so co dau: {sumSigned}");
    }
}
