/*
 * Bài 11. 
Viết một chương trình cho phép người dùng nhập nội dung và tên file từ bàn phím. 
Chương trình sau đó ghi nội dung vào file văn bản và sau đó đọc nội dung từ file và hiển thị lên màn hình.
*/

using System;
using System.IO;


namespace BT11_11_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap ten file: ");
            String fileName=Console.ReadLine();
            // Nhập nội dung từ bàn phím
            Console.Write("Nhap noi dung can ghi vao file: ");
            string content = Console.ReadLine();

            // Ghi nội dung vào file
            File.WriteAllText(fileName, content);
            Console.WriteLine("Noi dung da duoc ghi vao file.");

            // Đọc nội dung từ file
            string readContent = File.ReadAllText(fileName);

            // Hiển thị nội dung lên màn hình
            Console.WriteLine("\nNoi dung doc tu file:");
            Console.WriteLine(readContent);
        }
    }
}
