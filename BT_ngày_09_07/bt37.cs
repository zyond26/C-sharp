using System;
using System.Collections.Generic;
class Program
{
static void Main()
{
// Tạo một danh sách các số nguyên
List<int> numbers = new List<int>();
// Thêm các phần tử vào danh sách
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
// Hiển thị các phần tử của danh sách
foreach (int number in numbers)
{
Console.WriteLine(number);
}
}
}
