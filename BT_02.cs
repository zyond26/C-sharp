using System;

namespace BT_02
{
    class Program

    {
        static void Main()
        {
            //  a: Tìm số lớn nhất và nhỏ nhất trong dãy số nguyên 1 byte
            Console.Write("Nhap day so nguyen: ");
            string[] inputA = Console.ReadLine().Split();
            sbyte[] numbersA = Array.ConvertAll(inputA, s => Convert.ToSByte(s));

            sbyte max = sbyte.MinValue;
            sbyte min = sbyte.MaxValue;

            foreach (sbyte num in numbersA)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"So lon nhat: {max}");
            Console.WriteLine($"So nho nhat: {min}");
            Console.WriteLine();

            //  b: Tính tổng các số chẵn trong dãy số nguyên 1 byte
            Console.Write("Nhap day so nguyen : ");
            string[] inputB = Console.ReadLine().Split();
            sbyte[] numbersB = Array.ConvertAll(inputB, s => Convert.ToSByte(s));

            int sumEven = 0;

            foreach (sbyte num in numbersB)
            {
                if (num % 2 == 0)
                    sumEven += num;
            }

            Console.WriteLine($"Tong cac so chan: {sumEven}");
            Console.WriteLine();

            // c: Tính tổng các số từ 1 đến n
            Console.Write("Nhap so nguyen: ");
            byte n = Convert.ToByte(Console.ReadLine());

            int sum = (n * (n + 1)) / 2;

            Console.WriteLine($"Tong tu 1 den {n}: {sum}");
            Console.WriteLine();

            //  d: Tính tổng các chữ số của một số nguyên không dấu kiểu byte
            Console.Write("nhap mot so nguyen ");
            byte number = Convert.ToByte(Console.ReadLine());

            int sumDigits = 0;
            byte tempNumber = number;

            while (tempNumber > 0)
            {
                sumDigits += tempNumber % 10;
                tempNumber /= 10;
            }

            Console.WriteLine($"tong cac so cua {number}: {sumDigits}");
        }
    }
}