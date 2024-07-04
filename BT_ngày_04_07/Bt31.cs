using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        try
        {
            NhapSoLuongSinhVien();
            NhapThongTinSinhVien();
            HienThiThongTinSinhVien();
            HienThiSinhVienDiemCao();
            DemSinhVienDiemTrungBinhLonHon5();
            SapXepSinhVienTheoDiemTB();
            SapXepSinhVienTheoTen();
            GhiThongTinVaoFile();
            DocThongTinTuFile();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
        }
    }

    static void NhapSoLuongSinhVien()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int soLuong = int.Parse(Console.ReadLine());
        for (int i = 0; i < soLuong; i++)
        {
            danhSachSinhVien.Add(new SinhVien());
        }
    }

    static void NhapThongTinSinhVien()
    {
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            try
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                Console.Write("MSSV: ");
                danhSachSinhVien[i].MSSV = Console.ReadLine();
                Console.Write("Họ tên: ");
                danhSachSinhVien[i].HoTen = Console.ReadLine();
                Console.Write("Điểm Toán: ");
                danhSachSinhVien[i].DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                danhSachSinhVien[i].DiemLy = double.Parse(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                danhSachSinhVien[i].DiemHoa = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu không hợp lệ, xin vui lòng nhập lại.");
                i--;
            }
        }
    }

    static void HienThiThongTinSinhVien()
    {
        Console.WriteLine("\nThông tin sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm TB: {sv.DiemTrungBinh:F2}");
        }
    }

    static void HienThiSinhVienDiemCao()
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 9.5)
            {
                Console.WriteLine($"\nSinh viên có điểm trung bình trên 9.5:");
                Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm TB: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    static void DemSinhVienDiemTrungBinhLonHon5()
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5)
            {
                count++;
            }
        }
        Console.WriteLine($"\nSố sinh viên có điểm trung bình lớn hơn 5.0: {count}");
    }

    static void SapXepSinhVienTheoDiemTB()
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp theo điểm trung bình từ thấp đến cao:");
        HienThiThongTinSinhVien();
    }

    static void SapXepSinhVienTheoTen()
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.HoTen.CompareTo(sv2.HoTen));
        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp theo tên:");
        HienThiThongTinSinhVien();
    }

    static void GhiThongTinVaoFile()
    {
        Console.Write("\nNhập tên file để ghi thông tin sinh viên: ");
        string tenFile = Console.ReadLine();
        try
        {
            using (StreamWriter sw = new StreamWriter(tenFile))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    sw.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh:F2}");
                }
            }
            Console.WriteLine("Ghi thông tin thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Có lỗi khi ghi file: " + ex.Message);
        }
    }

    static void DocThongTinTuFile()
    {
        Console.Write("\nNhập tên file để đọc thông tin sinh viên: ");
        string tenFile = Console.ReadLine();
        try
        {
            using (StreamReader sr = new StreamReader(tenFile))
            {
                string line;
                danhSachSinhVien.Clear();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    danhSachSinhVien.Add(new SinhVien
                    {
                        MSSV = parts[0],
                        HoTen = parts[1],
                        DiemToan = double.Parse(parts[2]),
                        DiemLy = double.Parse(parts[3]),
                        DiemHoa = double.Parse(parts[4])
                    });
                }
            }
            Console.WriteLine("Đọc thông tin thành công.");
            HienThiThongTinSinhVien();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Có lỗi khi đọc file: " + ex.Message);
        }
    }
}
