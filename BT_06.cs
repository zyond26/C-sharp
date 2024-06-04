using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập mảng từ người dùng
        double[] numbers = new double[8];
        Console.WriteLine("nhap 1 mang so thuc: ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Tính trung bình cộng
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Length;
        Console.WriteLine($"TBC cua cac so trong mang {average}");

        // Tìm giá trị lớn nhất và nhỏ nhất
        double max = numbers[0];
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"Gia tri lon nhat la : {max}");
        Console.WriteLine($"Gia tri nho nhat la : {min}");

        Console.ReadLine(); 
    }
}
