// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Person obs = new Student { Name = "Tạ Hữu Anh Bình", Major = "ICT" };

        if (obs is Student student)
        {
            student.kpi();
        }
        else
        {
            Console.WriteLine("obs is not a Student.");
        }
    }
}
