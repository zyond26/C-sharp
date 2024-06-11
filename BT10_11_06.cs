/*
 * Bài 10
Viết một chương trình cho phép người dùng nhập thông tin của n sinh viên gồm tên và điểm, ở đó n được nhập từ bàn phím.
Sau đó, hiển thị thông tin của từng sinh viên và tính điểm trung bình của cả lớp.
Sử dụng cấu trúc (struct) để lưu trữ thông tin của sinh viên.
*/

using System;
using System.Collections.Generic;
public struct SinhVien
{
    public string Ten;
    public float Diem;
}
internal class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("nhap n sinh vien: ");
        n = int.Parse(Console.ReadLine());
        List<SinhVien> danhSachSinhVien = new List<SinhVien>(n);

        for (int i = 0; i < n; i++)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("nhap thong tin cho sinh vien thu " + (i + 1) + ": ");
            Console.Write("Ten: ");
            sv.Ten = Console.ReadLine();
            Console.Write("Diem: ");
            sv.Diem = float.Parse(Console.ReadLine());
            danhSachSinhVien.Add(sv);
        }
        // Hiển thị thông tin của từng sinh viên
        Console.WriteLine("\nThong tin sinh vien:");
        for (int i = 0; i < danhSachSinhVien.Count; ++i)
        {
            Console.WriteLine("Sinh vien thu " + (i + 1) + ":");
            Console.WriteLine("Ten: " + danhSachSinhVien[i].Ten);
            Console.WriteLine("Diem: " + danhSachSinhVien[i].Diem);
        }

        // Tính điểm trung bình của cả lớp
        float tongDiem = 0;
        for (int i = 0; i < danhSachSinhVien.Count; ++i)
        {
            tongDiem += danhSachSinhVien[i].Diem;
        }
        float diemTrungBinh = tongDiem / n;

        // Hiển thị điểm trung bình của cả lớp
        Console.WriteLine("\nDiem trung binh cua ca lop: " + diemTrungBinh);
    }
}
    


