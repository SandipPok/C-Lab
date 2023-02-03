using System.Data.SqlClient;
using databaseConnect.Models;

namespace databaseConnect.Repository
{
    public class EmployeeRepo
    {
        string conStr = @"Data Source=LAPTOP-S3QP8D6B\SQLEXPRESS02;Database=ADO_test;Integrated Security=SSPI";

        public void AddEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string insertQuery = $"INSERT INTO ADOTest VALUES(" + $"{emp.Id}, '{emp.Name}','{emp.Address}','{emp.PhoneNo}')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT * FROM  ADOTest";
                SqlCommand cm = new SqlCommand (query, con);

                using (SqlDataReader reader = cm.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(reader["Id"]);
                        employee.Name = reader["Name"].ToString();
                        employee.Address = reader["Address"].ToString();
                        employee.PhoneNo = Convert.ToInt64(reader["PhoneNumber"]);
                        employees.Add(employee);
                    }
                }
                con.Close();
            }
            return employees;
        }
    }
}
