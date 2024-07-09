/*Sửa code trên để tạo 1 danh sách listf các số thực 4 byte.
Bổ sung vào cuối list lần lượt các số 3.5,-1.2, 7.8,-5
Duyệt danh sách theo chỉ số (không sử dụng foreach) để hiển thị các phần tử
Sắp xếp danh sách theo thứ tự tăng dần*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một danh sách các số thực 4 byte
        List<float> listf = new List<float>();

        // Thêm các phần tử vào danh sách
        listf.Add(3.5f);
        listf.Add(-1.2f);
        listf.Add(7.8f);
        listf.Add(-5f);

        // Duyệt danh sách theo chỉ số để hiển thị các phần tử
        Console.WriteLine("Các phần tử của danh sách:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        listf.Sort();

        // Hiển thị danh sách sau khi đã sắp xếp
        Console.WriteLine("\nDanh sách sau khi sắp xếp:");
        foreach (float number in listf)
        {
            Console.WriteLine(number);
        }
    }
}
