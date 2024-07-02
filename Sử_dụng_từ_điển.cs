/*Bài tập 7: Sử dụng từ điển

Tạo một chương trình đơn giản trong C# sử dụng Từ điển từ với System.Collections.Generic để lưu trữ và truy xuất dữ liệu.

Cách thực hiện:

- Trong phương pháp Main, tạo Dictionary<TKey, TValue>.

- Thêm một số cặp key-giá trị vào Từ điển. Các phím phải là duy nhất và có thể thuộc bất kỳ loại nào. 
Các giá trị cũng có thể thuộc bất kỳ loại nào.

- Sử dụng phương pháp ContainsKey để kiểm tra xem một key có tồn tại trong Từ điển hay không.

- Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một key nhất định một cách an toàn.

- Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng.

- Đầu ra của chương trình là Từ điển lưu trữ và truy xuất chính xác các cặp key-giá trị và các phương thức ContainsKey và
TryGetValue xác định chính xác xem khóa có tồn tại trong Từ điển hay không và truy xuất giá trị liên quan một cách an toàn.
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Tạo một Dictionary<TKey, TValue>
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Thêm một số cặp key-giá trị vào Từ điển
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        dictionary.Add(4, "Four");

        // Sử dụng phương pháp ContainsKey để kiểm tra xem một key có tồn tại trong Từ điển hay không
        Console.WriteLine("Key 1 tồn tại: " + dictionary.ContainsKey(1));
        Console.WriteLine("Key 5 tồn tại: " + dictionary.ContainsKey(5));

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một key nhất định một cách an toàn
        if (dictionary.TryGetValue(2, out string value))
        {
            Console.WriteLine("Giá trị của key 2: " + value);
        }
        else
        {
            Console.WriteLine("Không tìm thấy key 2");
        }

        if (dictionary.TryGetValue(5, out value))
        {
            Console.WriteLine("Giá trị của key 5: " + value);
        }
        else
        {
            Console.WriteLine("Không tìm thấy key 5");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
        Console.WriteLine("\nCác cặp key-giá trị trong Từ điển:");
        foreach (KeyValuePair<int, string> kvp in dictionary)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
    }
}
