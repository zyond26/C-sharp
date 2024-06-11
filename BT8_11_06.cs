/*
*/

using System;
using System.Collections.Generic;
using System.Text;

class CompleteProgram
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Display ASCII Table");
            Console.WriteLine("2. Display UTF-8 Table for Code Page 65001");
            Console.WriteLine("3. Beep on Space Key Press");
            Console.WriteLine("4. Count Character Occurrences in a String");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayASCIITable();
                    break;
                case "2":
                    DisplayUTF8Table();
                    break;
                case "3":
                    BeepOnSpace();
                    break;
                case "4":
                    CountCharacterOccurrences();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

//    a.Viết một chương trình hiển thị bảng mã ASCII.

    static void DisplayASCIITable()
    {
        Console.WriteLine("ASCII Table:");
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine($"{i} : {(char)i}");
        }
    }

    //b. Viết chương trình để hiển thị bảng mã UTF-8 của trang mã 65001

    static void DisplayUTF8Table()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("UTF-8 Table for Code Page 65001:");

        for (int i = 0; i <= 0x10FFFF; i++)
        {
            if (i >= 0xD800 && i <= 0xDFFF) continue; // Skip surrogate pairs
            if (i < 128 || (i >= 0xA0 && i <= 0x10FFFF))
            {
                Console.Write($"{i:X4} : {char.ConvertFromUtf32(i)} ");
                if (i % 10 == 0) Console.WriteLine(); // New line for readability
            }
        }
        Console.WriteLine();
    }
    //c. Viết chương trình phát tiếng beep khi nhấn phím space

    static void BeepOnSpace()
    {
        Console.WriteLine("Press Space to beep. Press Esc to return to main menu.");
        do
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        } while (true);
    }

    //d. Viết chương trình nhập vào một chuỗi kí tự từ người dùng, đếm số lần xuất hiện của mỗi kí tự trong chuỗi và hiển thị kết quả đếm.

    static void CountCharacterOccurrences()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Character occurrences:");
        foreach (var item in charCount)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
