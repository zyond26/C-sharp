/*
 Bài 49. Viết chương trình C#, trong đó viết 1 hàm static Generic 1 biến đa công dụng: 
- Có thể truyền 1 mảng các số nguyên 4 byte, mảng số nguyên không dấu 4 byte, mảng số thực 4byte hoặc
mảng số thực 8 byte để nhận về giá trị bé nhất của mảng. 
- Hàm duyệt mảng theo từng phần tử để xác định giá trị nhỏ nhất.
- Trong lớp chứa hàm Main() gọi hàm để thử cho các trường hợp của biến mảng như sau:
+ Khai báo 1 biến kiểu dynamic là min_value
+ Gọi hàm với mảng số nguyên 4 byte và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value
+ Gọi hàm với mảng số nguyên 4 byte không dấu và gán giá trị trả về cho min_value rồi sử dụng ToString() để in ra giá trị của min_value.
*/


using System;
using System.Text;

class Program
{
    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng.");
        }

        T minValue = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }
        return minValue;
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        // Khai báo biến kiểu dynamic
        dynamic min_value;

        // Mảng số nguyên 4 byte
        int[] intArray = { 5, 3, 9, 1, 4 };
        min_value = FindMin(intArray);
        Console.WriteLine($"Giá trị bé nhất trong mảng số nguyên 4 byte: {min_value.ToString()}");

        // Mảng số nguyên không dấu 4 byte
        uint[] uintArray = { 10, 3, 7, 2, 8 };
        min_value = FindMin(uintArray);
        Console.WriteLine($"Giá trị bé nhất trong mảng số nguyên không dấu 4 byte: {min_value.ToString()}");

        // Mảng số thực 4 byte
        float[] floatArray = { 5.5f, 3.3f, 9.9f, 1.1f, 4.4f };
        min_value = FindMin(floatArray);
        Console.WriteLine($"Giá trị bé nhất trong mảng số thực 4 byte: {min_value.ToString()}");
        // Mảng số thực 8 byte
        double[] doubleArray = { 5.55, 3.33, 9.99, 1.11, 4.44 };
        min_value = FindMin(doubleArray);
        Console.WriteLine($"Giá trị bé nhất trong mảng số thực 8 byte: {min_value.ToString()}");
    }
}
