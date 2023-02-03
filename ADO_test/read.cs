using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO_test
{
    class ReadingData
    {
        static void ConnectAndRead()
        {
            SqlConnection conn = null;
            try
            {
                string conStr = @"Data Source=LAPTOP-S3QP8D6B\SQLEXPRESS02;Database=ADO_test;Integrated Security=SSPI";
                conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("Connection Established Successfully");
                string query = "SELECT * FROM ADOTest";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine("Name\t Address\t Phone Number");
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"] + " \t" + sdr["Address"] + " \t" + sdr["PhoneNumber"]);
                }
                Console.WriteLine("All Records are fetched Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opps! Something went wrong. " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            ConnectAndRead();
        }
    }
}
