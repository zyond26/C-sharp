using System;

namespace Example_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a. Sử dụng C# nhập từ bàn phím 2 số nguyên a và b kiểu 4 byte, có sử dụng điều khiển exception để nếu nhập sai thì nhập lại. 
            //Sau đó in  ra màn hình tổng, hiệu, tích và thương(số nguyên), thương số thực của a và b và chương trình chạy ở mode Console.


            int a, b;
            while (true)
            {
                try
                {
                    Console.WriteLine("enter a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter  b: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid.please enter a valid value");
                }
            }
            Console.WriteLine("Tong 2 so: " + (a + b));
            Console.WriteLine("hieu 2 so: " + (a - b));
            Console.WriteLine("tich 2 so: " + (a * b));
            Console.WriteLine("thuong so nguyen: " + (a / b));
            Console.WriteLine("thuong so thuc: " + (float)(a / b));


            // b. Viết một chương trình nhận vào một mảng số nguyên có dấu kích thước 4 byte từ người dùng và tính tổng của các số trong mảng. 

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

            //c. Viết một chương trình C# model console nhận vào một số nguyên không dấu kích thước 4 byte từ người dùng và đảo ngược các chữ số của số đó. 

            Console.WriteLine("Nhap so:");
            int num = int.Parse(Console.ReadLine());

            int reverse = 0;
            while (num > 0)
            {
                reverse = reverse * 10 + (num % 10);
                num /= 10;
            }

            Console.WriteLine("So dao nguoc la: " + reverse);
        }
    }
}