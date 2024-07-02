/*Bài tập 1: Quản lý danh sách sinh viên

Viết một chương trình C# để quản lý danh sách sinh viên trong lớp. Sử dụng List<T> để lưu trữ thông tin sinh viên bao gồm tên và lớp. 
Cho phép người dùng thêm sinh viên mới, hiển thị danh sách sinh viên và tính tổng điểm của tất cả sinh viên.*/


using System;
using System.Collections.Generic;
using System.Text;

class SinhVien
{
    public string Ten { get; set; }
    public string Lop { get; set; }
    public double Diem { get; set; }

    public SinhVien(string ten, string lop, double diem)
    {
        Ten = ten;
        Lop = lop;
        Diem = diem;
    }

    public override string ToString()
    {
        return $"Tên: {Ten}, Lớp: {Lop}, Điểm: {Diem}";
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Consolde.InputEncoding = Encoding.UTF8;
        var sinhViens = new List<SinhVien>();
        string lenh;

        do
        {
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị tất cả sinh viên");
            Console.WriteLine("3. Tính tổng điểm");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            lenh = Console.ReadLine();

            switch (lenh)
            {
                case "1":
                    ThemSinhVien(sinhViens);
                    break;
                case "2":
                    HienThiSinhVien(sinhViens);
                    break;
                case "3":
                    TinhTongDiem(sinhViens);
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

    static void ThemSinhVien(List<SinhVien> sinhViens)
    {
        Console.Write("Nhập tên sinh viên: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập lớp: ");
        string lop = Console.ReadLine();
        double diem;
        do
        {
            Console.Write("Nhập điểm (0 - 10): ");
            diem = double.Parse(Console.ReadLine());
            if (diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
            }
        } while (diem < 0 || diem > 10);

        sinhViens.Add(new SinhVien(ten, lop, diem));
        Console.WriteLine("Thêm sinh viên thành công.");
    }

    static void HienThiSinhVien(List<SinhVien> sinhViens)
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sinhVien in sinhViens)
        {
            Console.WriteLine(sinhVien);
        }
    }

    static void TinhTongDiem(List<SinhVien> sinhViens)
    {
        double tongDiem = 0;
        foreach (var sinhVien in sinhViens)
        {
            tongDiem += sinhVien.Diem;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {tongDiem}");
    }
}
