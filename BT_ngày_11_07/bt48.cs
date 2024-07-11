/*Bài tập 48.
Nhập vào 1 danh sách các đối tượng Student gồm 2 trường ID kiểu string và GPA (điểm trung bình).
Nếu nhập điểm trung bình sai thì bỏ qua, nếu nhập trường ID là "#" thì dừng việc nhập. 
Tạo 1 biến dict1 kiểu Diction gồm khóa là ID và trường giá trị là điểm trung bình. 
Xác định điểm trung bình của sinh viên có ID là "123456".*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt48
{
    class Student
    {
        public string ID { get; set; }
        public float GPA { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>();
            string inputID;
            float inputGPA;
            while (true)
            {
                Console.WriteLine("nhập ID sinh viên(nhập # để dừng): ");
                inputID = Console.ReadLine();
                if(inputID == "#")
                {
                    break;
                }
                Console.WriteLine("nhập GPA:");
                 if (float.TryParse(Console.ReadLine(), out inputGPA) && inputGPA >= 0 && inputGPA <= 4)
                {
                    students.Add(new Student { ID = inputID, GPA = inputGPA });
                }
                else
                {
                    Console.WriteLine("GPA không hợp lệ, bỏ qua.");
                }
            }
            Dictionary<string,float> dict1 = new Dictionary<string,float>();
            foreach (Student student in students)
            {
                dict1[student.ID] = student.GPA;
            }
            // Xác định điểm trung bình của sinh viên có ID là "123456"
            string searchID = "123456";
            if (dict1.TryGetValue(searchID, out float gpa))
            {
                Console.WriteLine($"Điểm trung bình của sinh viên có ID {searchID} là: {gpa}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên có ID {searchID}.");
            }
        }
    }
}
