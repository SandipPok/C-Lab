using System.Data.SqlClient;

namespace ADO_test
{
    class Insertion
    {
        static void ConnectAndInsert()
        {
            SqlConnection conn = null;
            try
            {
                string conStr = @"Data Source=LAPTOP-S3QP8D6B\SQLEXPRESS02;Database=ADO_test;Integrated Security=SSPI";
                conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("Connection Established Successfully");
                int id = 1;
                string name = "Don";
                string address = "Koteshwor";
                long phone = 1234567880;
                string query = "INSERT INTO ADOTest VALUES(" + id + ",'" + name + "','" + address + "'," + phone + ")";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                int n = sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + " Record Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            ConnectAndInsert();
        }
    }
}