/*Bài tập 16. Viết chương trình C# console, dịch ở mode Release 64bit, yêu cầu hiển thị tiếng Việt trong console:
+ Viết hàm static, đọc từ bàn phím số nguyên 1 byte, không dấu, nằm trong khoảng 2 đến 10, nếu nhập sai thì nhập lại.
+ Viết hàm static, đọc từ bàn phím 1 giá trị số nguyên 4 byte, nếu nhập sai thì nhập lại.
+ Viết hàm nhập vào 1 mảng 2 chiều các số nguyên 4 byte biết số phần tử của mảng là số nguyên dương m,n cho trước.
+ Viết hàm tính tổng các phần tử chia hết cho số nguyên dương p của mảng.
+ Trong lớp chứa hàm Main(), khai báo số nguyên m,n 1 byte không dấu, gọi hàm để nhập giá trị của m,n, in ra màn hình giá trị được nhập.
+ Trong lớp chứa hàm Main(), khai báo mảng 2 chiều các số nguyên 4 byte a, và cấp phát để a gồm m*n phần tử.
+ Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím, in ra màn hình giá trị được nhập của mảng a.
+ Gọi hàm để tính tổng các phần tử của mảng chia hết cho 2024*/



using System;

class Program
{
    static byte ReadByte2to10()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte trong khoảng 2 đến 10: ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static int ReadInt()
    {
        int value;
        while (true)
        {
            Console.Write("Nhập số nguyên 4 byte: ");
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static void ReadMatrix(int[,] matrix, int m, int n)
    {
        Console.WriteLine($"Nhập {m} x {n} phần tử của ma trận:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhập phần tử [{i},{j}]: ");
                matrix[i, j] = ReadInt();
            }
        }
    }

    static int SumDivisibleByP(int[,] matrix, int m, int n, int p)
    {
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % p == 0)
                    sum += matrix[i, j];
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        byte m, n;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhập kích thước ma trận:");
        m = ReadByte2to10();
        n = ReadByte2to10();
        Console.WriteLine($"m = {m}, n = {n}");

        int[,] a = new int[m, n];
        ReadMatrix(a, m, n);
        Console.WriteLine("Giá trị của ma trận a:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{a[i, j]} ");
            Console.WriteLine();
        }

        int sum = SumDivisibleByP(a, m, n, 2024);
        Console.WriteLine($"Tổng các phần tử chia hết cho 2024 là: {sum}");
    }
}