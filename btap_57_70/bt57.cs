using System;
using System.Text;
using System.Text.Json;

class Program
{
    public static string CalculatorCircle(double r)
    {
        var circle = new
        {
            dien_tich = Math.PI * r * r,
            chu_vi = 2 * Math.PI * r,
            duong_kinh = 2 * r
        };
        return JsonSerializer.Serialize(circle);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        double r;
        while (true)
        {
            Console.Write("Nhập vào bán kính r: ");
            if (double.TryParse(Console.ReadLine(), out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Bán kính không hợp lệ, vui lòng nhập lại.");
            }
        }

        // Gọi hàm để hiển thị kết quả đầu ra
        string result = CalculatorCircle(r);
        Console.WriteLine("Kết quả: " + result);
    }
}
