/*Exercise 1: Custom Validation Exception

Write a C# program that takes a student's age as input and checks if it meets the eligibility criteria for admission to a university. The criteria are as follows:

The student's age must be between 18 and 25 (inclusive) to be eligible for admission.
If the age is not within this range, throw a custom exception called AgeOutOfRangeException.
 */

using System;

public class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Nhập tuổi của sinh viên từ người dùng
            Console.Write("Nhap tuoi cua sinh vien: ");
            int age = int.Parse(Console.ReadLine());

            // Kiểm tra điều kiện tuổi để xem có đáp ứng tiêu chí đăng ký vào trường đại học hay không
            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException("tuoi ko dap ung tieu chi dki vao truong.");
            }

            Console.WriteLine("sinh vien du tuoi dki vao truong.");
        }
        catch (FormatException)
        {
            Console.WriteLine("vui long nhap so nguyen:  ");
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

