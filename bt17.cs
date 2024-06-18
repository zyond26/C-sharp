/*Bài 17
Viết hàm static đếm số các từ của 1 xâu kí tự
Ví dụ "w3resource.com" thì giá trị trả lại là 3.
Trong lớp chứa hàm Main() khai báo st là biến xâu kí tự. Nhập st từ bàn phím.
Nếu st là "#" thì phát tiếng beep. Trái lại gọi hàm để in ra số từ của st.*/



using System;

class Program
{
    static int CountWords(string str)
    {
        // Loại bỏ các khoảng trắng ở đầu và cuối chuỗi
        str = str.Trim();

        // Nếu chuỗi rỗng, trả về 0 từ
        if (string.IsNullOrEmpty(str))
            return 0;

        // Tách chuỗi thành các từ dựa trên khoảng trắng
        string[] words = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        // Trả về số lượng từ
        return words.Length;
    }

    static void Main()
    {
        // Đọc chuỗi từ bàn phím
        Console.Write("Nhap chuoi: ");
        string st = Console.ReadLine();

        // Nếu chuỗi là "#", phát tiếng bíp
        if (st == "#")
        {
            Console.Beep();
        }
        else
        {
            // Gọi hàm đếm số từ và in kết quả
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong chuỗi: {wordCount}");
        }
    }
}