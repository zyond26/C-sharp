using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace C_btap2_ngày_02_07
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;  
            string csvFilePath = "students.csv";

            // Tạo danh sách các đối tượng Student 
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Diệu", Age = 19, Grade = "A+" },
                new Student { Id = 2, Name = "Bình", Age = 19, Grade = "B" },
                new Student { Id = 3, Name = "Tiến", Age = 18, Grade = "A" }
            };

            // Ghi danh sách sinh viên vào tệp CSV
            WriteStudentsToCsv(csvFilePath, students);

            // Đọc danh sách sinh viên từ tệp CSV
            List<Student> studentsFromCsv = ReadStudentsFromCsv(csvFilePath);

            // Hiển thị danh sách sinh viên từ tệp CSV
            foreach (var student in studentsFromCsv)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }

        //Phương thức đọc dữ liệu từ tệp CSV và chuyển đổi thành danh sách các đối tượng Student
        static List<Student> ReadStudentsFromCsv(string filePath)
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    Student student = new Student
                    {
                        Id = int.Parse(values[0]),
                        Name = values[1],
                        Age = int.Parse(values[2]),
                        Grade = values[3]
                    };
                    students.Add(student);
                }
            }

            return students;
        }

        //Phương thức ghi danh sách các đối tượng Student vào tệp CSV
        static void WriteStudentsToCsv(string filePath, List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    string line = $"{student.Id},{student.Name},{student.Age},{student.Grade}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
