using System;
using System.Data.SqlClient;
using System.Text;
namespace Database_Operation
{
    class InsertStatement
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DELL_VOSTRO\SQLEXPRESS;Initial Catalog=Demodb;User ID=cmc;Password=12345678";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "insert into demo values(7, 'Python')";
            sql = "insert into demo values(8, 'Python')";
            sql = "insert into demo values(9, 'Python')";
            sql = "insert into demo values(10, 'Python')";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            Console.WriteLine("Dữ liệu đã được thêm thành công.");
        }
    }
}