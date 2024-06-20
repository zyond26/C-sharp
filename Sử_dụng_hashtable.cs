/*Bài tập 6: Sử dụng Hashtable

Tạo một chương trình đơn giản trong C# sử dụng Hashtable từ System.Collections để lưu trữ và truy xuất dữ liệu.

Cách thực hiện:

- Trong phương thức Main, tạo một Hashtable.

- Thêm một số cặp key-giá trị vào Hashtable. Các key phải là duy nhất và có thể thuộc bất kỳ loại nào. 
Các giá trị cũng có thể thuộc bất kỳ loại nào.

- Sử dụng phương thức ContainsKey để kiểm tra xem một key có tồn tại trong Hashtable hay không.

- Sử dụng phương thức ContainsValue để kiểm tra xem một giá trị nhất định có tồn tại trong Hashtable hay không.

- Sử dụng chỉ mục (dấu ngoặc vuông) để truy xuất giá trị được liên kết với một khóa nhất định.

- Sử dụng vòng lặp foreach để lặp lại các key hoặc giá trị của Hashtable và in chúng.

- Đầu ra của chương trình là Hashtable lưu trữ và truy xuất chính xác các cặp key-giá trị và các phương thức ContainsKey và
ContainsValue xác định chính xác xem key hoặc giá trị có tồn tại trong Hashtable hay không.
*/



using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Tạo một Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm một số cặp key-giá trị vào Hashtable
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add("Three", 3);
        hashtable.Add("Four", 4.0);

        // Kiểm tra xem một key có tồn tại trong Hashtable hay không
        Console.WriteLine("Key 1 tồn tại: " + hashtable.ContainsKey(1));
        Console.WriteLine("Key 'Five' tồn tại: " + hashtable.ContainsKey("Five"));

        // Kiểm tra xem một giá trị có tồn tại trong Hashtable hay không
        Console.WriteLine("Giá trị 'Two' tồn tại: " + hashtable.ContainsValue("Two"));
        Console.WriteLine("Giá trị 5 tồn tại: " + hashtable.ContainsValue(5));

        // Truy xuất giá trị được liên kết với một khóa nhất định
        Console.WriteLine("Giá trị của key 1: " + hashtable[1]);
        Console.WriteLine("Giá trị của key 'Four': " + hashtable["Four"]);

        // Sử dụng vòng lặp foreach để lặp lại các key và giá trị của Hashtable và in chúng
        Console.WriteLine("\nCác cặp key-giá trị trong Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}
