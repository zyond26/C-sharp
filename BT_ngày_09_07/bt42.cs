using System;
using System.Collections.Generic;
class Program
{
static void Main()
{
List<int> numbers = new List<int>
{ 5, 3, 9, 1 };
// Sắp xếp danh sách
numbers.Sort();
// Đảo ngược danh sách
numbers.Reverse();
// Chèn một phần tử tại một chỉ số
cụ thể
numbers.Insert(2, 7);
// Xóa một phần tử theo giá trị
numbers.Remove(3);
// Xóa một phần tử tại một chỉ số cụ thể
numbers.RemoveAt(0);
// Kiểm tra xem danh sách có chứa một
phần tử cụ thể hay không
bool containsNine = numbers.Contains(9);
// Hiển thị các phần tử của danh sách
foreach (int number in numbers)
{
Console.WriteLine(number);
}
// Hiển thị kết quả của việc kiểm tra
chứa phần tử
Console.WriteLine("Contains 9: " +
containsNine);
} }