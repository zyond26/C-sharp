using System;
using System.Data.SqlClient;

class Entity
{
    static string connectionString = @"Data Source=ZYOND\SQLEXPRESS;Initial Catalog=Bai77Chuong7;User ID=dieu;Password=dieu12345678";

    static void Connect()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            Console.WriteLine("Mở kết nối!");
            conn.Close();
        }
    }

    static void Main()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo bảng Students
                string createStudentsTable = @"
                    CREATE TABLE Students (
                        StudentID VARCHAR(50) PRIMARY KEY,
                        FirstName NVARCHAR(50),
                        LastName NVARCHAR(50),
                        Age INT,
                        Gender NVARCHAR(10)
                    );";
                ExecuteNonQuery(connection, createStudentsTable);

                // Tạo bảng Courses
                string createCoursesTable = @"
                    CREATE TABLE Courses (
                        CourseID VARCHAR(50) PRIMARY KEY,
                        CourseName NVARCHAR(100),
                        Credits INT
                    );";
                ExecuteNonQuery(connection, createCoursesTable);

                // Tạo bảng Registrations
                string createRegistrationsTable = @"
                    CREATE TABLE Registrations (
                        RegistrationID VARCHAR(50) PRIMARY KEY,
                        StudentID VARCHAR(50) NOT NULL,
                        CourseID VARCHAR(50) NOT NULL,
                        RegistrationDate DATE,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                    );";
                ExecuteNonQuery(connection, createRegistrationsTable);

                // Thêm dữ liệu vào bảng Students
                string insertStudents = @"
                    INSERT INTO Students (StudentID, FirstName, LastName, Age, Gender)
                    VALUES ('S001', 'John', 'Doe', 20, 'Male'),
                           ('S002', 'Jane', 'Smith', 22, 'Female');";
                ExecuteNonQuery(connection, insertStudents);

                // Thêm dữ liệu vào bảng Courses
                string insertCourses = @"
                    INSERT INTO Courses (CourseID, CourseName, Credits)
                    VALUES ('C001', 'Mathematics', 3),
                           ('C002', 'History', 4);";
                ExecuteNonQuery(connection, insertCourses);

                // Thêm dữ liệu vào bảng Registrations
                string insertRegistrations = @"
                    INSERT INTO Registrations (RegistrationID, StudentID, CourseID, RegistrationDate)
                    VALUES ('R001', 'S001', 'C001', '2023-07-01'),
                           ('R002', 'S002', 'C002', '2023-07-01');";
                ExecuteNonQuery(connection, insertRegistrations);

                // Truy xuất dữ liệu từ bảng Students
                string selectStudents = "SELECT * FROM Students";
                using (SqlCommand command = new SqlCommand(selectStudents, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["StudentID"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Age: {reader["Age"]}, Gender: {reader["Gender"]}");
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
    }

    static void ExecuteNonQuery(SqlConnection connection, string query)
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.ExecuteNonQuery();
        }
    }
}
