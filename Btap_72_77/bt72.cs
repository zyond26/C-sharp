using System;
using System.Data.SqlClient;
using System.Text;
namespace Database_Operation
{
    class DBConn
    {
        // Main Method
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Connect();
            Console.ReadKey();
        }

        static void Connect()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DELL_VOSTRO\SQLEXPRESS;Initial Catalog=Demodb;User ID=cmc;Password=12345678";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Mở kết nối!");
            // Đóng kết nối
            conn.Close();
            Console.WriteLine("Đóng kết nối!!!!!!!");
        }
    }
}