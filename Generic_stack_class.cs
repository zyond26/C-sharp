/*Bài tập 5: Generic Stack Class

Tạo một lớp Generic trong C # để thực hiện cấu trúc dữ liệu ngăn xếp đơn giản. Lớp sẽ có thể xử lý các phần tử của bất kỳ kiểu dữ liệu nào: 
số nguyên, số thực, chuỗi, v.v.

Cách thực hiện:

- Định nghĩa một lớp Generic có tên MyStack. Lớp private List<T>  lưu trữ các phần tử của stack.\

- Bên trong lớp MyStack, định nghĩa một phương thức có tên là Push. Phương thức này nên lấy một tham số và thêm nó vào ngăn xếp.

- Bên trong lớp MyStack, định nghĩa một phương thức có tên là Pop. Phương pháp này sẽ loại bỏ và trả về phần tử trên cùng của ngăn xếp.
Nếu ngăn xếp trống, nó sẽ là một InvalidOperationException.

- Trong phương thức Main, kiểm tra lớp MyStack với các kiểu dữ liệu khác nhau. Ví dụ: tạo MyStack<int> và 
sử dụng các phương thức Push và Pop để thêm và xóa số nguyên. Lặp lại kiểm tra với MyStack<string>.

- Đầu ra của chương trình là lớp MyStack thực hiện cấu trúc dữ liệu ngăn xếp, với bất kì kiểu dữ liệu.*/



using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> elements = new List<T>();

    public void Push(T item)
    {
        elements.Add(item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp trống.");
        }

        T top = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return top;
    }

    public bool IsEmpty()
    {
        return elements.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        // Kiểm tra lớp MyStack với kiểu dữ liệu số nguyên
        Console.WriteLine("---Kiểm tra MyStack<int>---");
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // Output: 3
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // Output: 2
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // Output: 1

        // Kiểm tra lớp MyStack với kiểu dữ liệu chuỗi
        Console.WriteLine("---Kiểm tra MyStack<string>---");
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("apple");
        stringStack.Push("banana");
        stringStack.Push("cherry");
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // Output: cherry
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // Output: banana
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // Output: apple

        // Kiểm tra ngăn xếp trống
        try
        {
            Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // Exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message); // Output: Ngăn xếp trống
        }
    }
}
