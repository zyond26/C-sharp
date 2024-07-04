
/*Bài tập 2: Từ điển Anh - Việt

Viết một chương trình C# để tạo ra một từ điển đơn giản giữa tiếng Anh và tiếng Việt. Sử dụng Dictionary<TKey, TValue> 
để lưu trữ các cặp từ và nghĩa tương ứng.
Cho phép người dùng nhập một từ tiếng Anh và hiển thị nghĩa tương ứng trong tiếng Việt.*/

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        var tuDien = new Dictionary<string, string>();
        string lenh;

        do
        {
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Tra từ");
            Console.WriteLine("3. Hiển thị tất cả các từ");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            lenh = Console.ReadLine();

            switch (lenh)
            {
                case "1":
                    ThemTu(tuDien);
                    break;
                case "2":
                    TraTu(tuDien);
                    break;
                case "3":
                    HienThiTatCa(tuDien);
                    break;
                case "4":
                    Console.WriteLine("Thoát...");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        } while (lenh != "4");
    }

    static void ThemTu(Dictionary<string, string> tuDien)
    {
        Console.Write("Nhập từ tiếng Anh: ");
        string tuTiengAnh = Console.ReadLine();
        Console.Write("Nhập nghĩa tiếng Việt: ");
        string nghiaTiengViet = Console.ReadLine();

        if (!tuDien.ContainsKey(tuTiengAnh))
        {
            tuDien.Add(tuTiengAnh, nghiaTiengViet);
            Console.WriteLine("Thêm từ thành công.");
        }
        else
        {
            Console.WriteLine("Từ đã tồn tại trong từ điển.");
        }
    }

    static void TraTu(Dictionary<string, string> tuDien)
    {
        Console.Write("Nhập từ tiếng Anh cần tra: ");
        string tuTiengAnh = Console.ReadLine();

        if (tuDien.TryGetValue(tuTiengAnh, out string nghiaTiengViet))
        {
            Console.WriteLine($"Nghĩa của '{tuTiengAnh}' là: {nghiaTiengViet}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy từ này trong từ điển.");
        }
    }

    static void HienThiTatCa(Dictionary<string, string> tuDien)
    {
        Console.WriteLine("Tất cả các từ trong từ điển:");
        foreach (var item in tuDien)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
