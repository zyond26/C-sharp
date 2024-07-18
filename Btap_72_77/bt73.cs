

using System.Data.SqlClient;
using System; 
namespace Database_Operation
{
    /// /////////////////73. a ///////////////////////////////////
 
    class SelectStatement
    {

     
        static void Main()
        {
            Read();
            Console.ReadKey();
        }

        static void Read()
        {
            string constr;

            SqlConnection conn;

            constr = @"Data Source=DELL_VOSTRO\SQLEXPRESS;Initial Catalog=Demodb;User ID=cmc;Password=12345678";

            conn = new SqlConnection(constr);

            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql, output = "";
            sql = "Select articleID, articleName from demo";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();

            // Đọc từng dòng (bản ghi)
            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " +
                                    dreader.GetValue(1) + "\n";
            }

            Console.Write(output);

            // Đóng
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}

///////////////////////////////// 73.b ///////////////////////
///

using System;
using System.Data.SqlClient;
namespace Database_Operation
{
    class SelectStatement
    {
        static void Main()
        {
            Read();
            Console.ReadKey();
        }

        static void Read()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DELL_VOSTRO\SQLEXPRESS;Initial Catalog=Demodb;User ID=cmc;Password=12345678";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;
            string sql, output = "";
            sql = "Select articleID, articleName from demo";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            // Đọc từng dòng của bảng
            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " +
                                    dreader.GetValue(1) + "\n";
            }
            Console.Write(output);
            // to close all the objects
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}
