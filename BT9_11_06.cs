/*Bài 9. kiểu xâu kí tự trong C#
a. Viết một chương trình nhận vào một chuỗi kí tự từ người dùng và đảo ngược chuỗi đó. In chuỗi đảo ngược lên màn hình.
b. Viết một chương trình nhận vào một chuỗi kí tự từ người dùng và đếm số lượng từ trong chuỗi đó. In kết quả lên màn hình
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CompleteProgram
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1.reverse a string ");
            Console.WriteLine("2.count words in a string");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReverseString();
                    break;
                case "2":
                    CountWordsInString();
                    break;                             
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void ReverseString()
    {
        Console.WriteLine("enter a string: ");
        string s= Console.ReadLine();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine("Reversed string: " + reversedString);
    }
    static void CountWordsInString()
    {
        Console.WriteLine("Enter a string to count words:");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine($"Number of words: {wordCount}");
    }
}
