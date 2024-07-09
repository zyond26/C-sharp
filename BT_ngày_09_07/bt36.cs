using System;
using System.Collections.Generic;

{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
    public interface Kpi
    {
        float kpi();
    }

    // Class Student inherits Person and implements Kpi
    public class Student : Person, Kpi
    {
        private string _department;

        public string Department
        {
            get { return _department; }
            set
            {
                if (value == "ICT" || value == "ECO")
                {
                    _department = value;
                }
                else
                {
                    throw new ArgumentException("Department must be 'ICT' or 'ECO'");
                }
            }
        }

        private float _gpa;
        public float Gpa
        {
            get { return _gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    _gpa = value;
                }
                else
                {
                    throw new ArgumentException("GPA must be between 0 and 4");
                }
            }
        }

        public float kpi()
        {
            return Gpa;
        }

        // Constructor
        public Student(string name, string id, string department, float gpa)
        {
            if (id.Length == 8 && int.TryParse(id, out _))
            {
                Name = name;
                Id = id;
                Department = department;
                Gpa = gpa;
            }
            else
            {
                throw new ArgumentException("Id must be 8 characters and all numeric");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // d. Declare obs of type Person and set it to null
            Person obs = null;

            // e. Allocate obs as a Student
            try
            {
                obs = new Student("Nguyễn Tiến Dũng", "12345678", "ICT", 3.5f);
                Console.WriteLine($"KPI of {obs.Name}: {((Student)obs).kpi()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // g. Allocate obs with wrong id or department and see effect
            try
            {
                obs = new Student("Lê Văn Nam", "1234567A", "SCI", 3.2f); // This will throw an error
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // h. Declare list1, list2 as lists of Person
            List<Person> list1 = new List<Person>();
            List<Person> list2 = new List<Person>();

            // Input list1
            Console.WriteLine("Enter students for list1 (23IT5), end with name '#':");
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "#") break;
                Console.Write("Id: ");
                string id = Console.ReadLine();
                Console.Write("Department: ");
                string department = Console.ReadLine();
                Console.Write("GPA: ");
                float gpa = float.Parse(Console.ReadLine());

                try
                {
                    list1.Add(new Student(name, id, department, gpa));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Input list2
            Console.WriteLine("Enter students for list2 (23IT6), end with name '#':");
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "#") break;
                Console.Write("Id: ");
                string id = Console.ReadLine();
                Console.Write("Department: ");
                string department = Console.ReadLine();
                Console.Write("GPA: ");
                float gpa = float.Parse(Console.ReadLine());

                try
                {
                    list2.Add(new Student(name, id, department, gpa));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Display list1
            Console.WriteLine("List1 (23IT5):");
            foreach (var student in list1)
            {
                Console.WriteLine($"{student.Name}, {((Student)student).Department}, {((Student)student).Gpa}");
            }

            // Display list2
            Console.WriteLine("List2 (23IT6):");
            foreach (var student in list2)
            {
                Console.WriteLine($"{student.Name}, {((Student)student).Department}, {((Student)student).Gpa}");
            }

            // k. Declare list_list and add list1, list2 to it
            List<List<Person>> list_list = new List<List<Person>> { list1, list2 };

            // Display list_list
            Console.WriteLine("List_list:");
            foreach (var list in list_list)
            {
                foreach (var student in list)
                {
                    Console.WriteLine($"{student.Name}, {((Student)student).Department}, {((Student)student).Gpa}");
                }
            }

            // l. Create Dictionary for list1 with key as id
            Dictionary<string, Student> dict1 = new Dictionary<string, Student>();
            foreach (Student student in list1)
            {
                dict1[student.Id] = student;
            }

            // Find student named "Nam"
            Console.WriteLine("Searching for students named 'Nam' in dict1:");
            foreach (var student in dict1.Values)
            {
                if (student.Name.Contains("Nam"))
                {
                    Console.WriteLine($"{student.Name}, {student.Id}, {student.Department}, {student.Gpa}");
                }
            }
        }
    }
}
