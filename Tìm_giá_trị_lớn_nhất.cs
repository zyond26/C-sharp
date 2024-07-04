/*Bài tập 4: Tìm giá trị lớn nhất

Tạo một hàm generic trong C# trả về giá trị max giữa 2 giá trị. Hàm sẽ có thể xử lý các giá trị của bất kỳ kiểu dữ liệu có thể so sánh nào:
số nguyên, số thực, chuỗi, v.v.

Cách thực hiện:

- Xác định một hàm generic có tên Max. Hàm này sẽ có hai tham số. Loại tham số này nên được giới hạn trong IComparable<T>.

- Bên trong hàm Max, so sánh hai tham số bằng hàm CompareTo. Trả về tham số lớn hơn.

- Trong Main, kiểm tra hàm Max với các kiểu dữ liệu khác nhau. Ví dụ: tạo hai biến số nguyên và in giá trị max hai số nguyên. 
Lặp lại thử nghiệm này với hai số thực và hai biến chuỗi.

- Đầu ra của chương trình sẽ hiển thị hàm Max trả về giá trị lớn nhất của hai giá trị, bất kể kiểu dữ liệu của chúng.*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        // Kiểm tra hàm Max với các kiểu dữ liệu khác nhau

        // Số nguyên
        Console.WriteLine("---Kiểu số nguyên----");
        Console.Write("nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("nhập b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Max giữa {a} và {b} là: {Max(a, b)}");

        // Số thực
        Console.WriteLine("-----Kiểu số thực------");
        Console.Write("nhập x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("nhập y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine($"Max giữa {x} và {y} là: {Max(x, y)}");

        // Chuỗi
        Console.WriteLine("-------Kiểu chuỗi----------");
        Console.Write("nhập chuỗi str1: ");
        string str1 = Console.ReadLine();
        Console.Write("nhập chuỗi str2: ");
        string str2 = Console.ReadLine();
        Console.WriteLine($"Max giữa \"{str1}\" và \"{str2}\" là: \"{Max(str1, str2)}\"");
    }

    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
