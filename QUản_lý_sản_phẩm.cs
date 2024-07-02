
/*Bài tập 3: Quản lý danh sách sản phẩm
Viết chương trình C# để quản lý danh sách sản phẩm trong cửa hàng. Sử dụng ArrayList để lưu trữ thông tin về sản phẩm bao gồm tên, 
mô tả và giá. Cho phép người dùng thêm sản phẩm mới, hiển thị danh sách sản phẩm và tìm kiếm sản phẩm theo tên.
Lưu ý: Trong mỗi bài tập, có thể sử dụng các phương thức và thuộc tính cơ bản của List<T>, Dictionary<TKey, TValue> và ArrayList để
thực hiện các thao tác thêm, sửa đổi, xóa và truy xuất các phần tử trong các cấu trúc dữ liệu.
 */


using System;
using System.Collections;
using System.Text;

class SanPham
{
    public string Ten { get; set; }
    public string MoTa { get; set; }
    public double Gia { get; set; }

    public SanPham(string ten, string moTa, double gia)
    {
        Ten = ten;
        MoTa = moTa;
        Gia = gia;
    }

    public override string ToString()
    {
        return $"Tên: {Ten}, Mô tả: {MoTa}, Giá: {Gia} nghin dong";
    }
}

class Program
{
    static void Main()
    {
        var sanPhams = new ArrayList();
        string lenh;
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        do
        {
            Console.WriteLine("1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị tất cả sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            lenh = Console.ReadLine();

            switch (lenh)
            {
                case "1":
                    ThemSanPham(sanPhams);
                    break;
                case "2":
                    HienThiSanPham(sanPhams);
                    break;
                case "3":
                    TimKiemSanPham(sanPhams);
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

    static void ThemSanPham(ArrayList sanPhams)
    {
        Console.Write("Nhập tên sản phẩm: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập mô tả sản phẩm: ");
        string moTa = Console.ReadLine();
        Console.Write("Nhập giá sản phẩm: ");
        double gia = double.Parse(Console.ReadLine());

        sanPhams.Add(new SanPham(ten, moTa, gia));
        Console.WriteLine("Thêm sản phẩm thành công.");
    }

    static void HienThiSanPham(ArrayList sanPhams)
    {
        Console.WriteLine("Danh sách sản phẩm:");
        foreach (SanPham sanPham in sanPhams)
        {
            Console.WriteLine(sanPham);
        }
    }

    static void TimKiemSanPham(ArrayList sanPhams)
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string ten = Console.ReadLine();

        bool timThay = false;
        foreach (SanPham sanPham in sanPhams)
        {
            if (sanPham.Ten.Equals(ten, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(sanPham);
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy sản phẩm này.");
        }
    }
}
