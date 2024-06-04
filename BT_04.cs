using System;

class Program
{
    static void Main()
    {
        // a: Kiểm tra số Palindrome      
        Console.Write("Nhap mot so nguyen ko dau size 8 byte: ");
        ulong number = Convert.ToUInt64(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine(isPalindrome ? "So nay la so Palindrome." : "So nay khong phai la so Palindrome.");
        Console.WriteLine();

        // b: Tính tổng các số trong mảng số nguyên có dấu kích thước 8 byte
        Console.Write("Nhap mang so nguyen co dau: ");
        string[] inputB = Console.ReadLine().Split();
        long[] numbersB = Array.ConvertAll(inputB, s => Convert.ToInt64(s));

        long sumSigned = 0;

        foreach (long num in numbersB)
        {
            sumSigned += num;
        }

        Console.WriteLine($"Tong cac so co dau: {sumSigned}");
    }

    static bool IsPalindrome(ulong number)
    {
        ulong reversed = 0, temp = number;

        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }

        return number == reversed;
    }
}
