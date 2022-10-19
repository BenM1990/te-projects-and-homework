using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {

            Department department = null;

            using (SqlConnection departmentConnection = new SqlConnection(connectionString))
            {

                departmentConnection.Open(); 

                SqlCommand departmentCommand = new SqlCommand("SELECT department_id, name FROM department WHERE department_id = @department_id;", departmentConnection);
                departmentCommand.Parameters.AddWithValue("@department_id", departmentId);

                SqlDataReader departmentReader = departmentCommand.ExecuteReader();

                if (departmentReader.Read()) 
                {
                    department = CreateDepartmentFromReader(departmentReader); 
                }
            }
            return department; 
        }


        public IList<Department> GetAllDepartments()
        {
            IList<Department> departments = new List<Department>();
            using (SqlConnection departmentConnection = new SqlConnection(connectionString))
            {
                departmentConnection.Open();
                SqlCommand departmentCommand = new SqlCommand("SELECT * FROM department", departmentConnection);
                

                SqlDataReader reader = departmentCommand.ExecuteReader(); // exectue the select query

                //create park object(s) from the data comming back from the reader
                while (reader.Read())
                {
                    Department department = CreateDepartmentFromReader(reader);
                    departments.Add(department);
                }
            }
            return departments;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE department SET name = @name WHERE department_id = @department_id;", conn);
                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);

                cmd.ExecuteNonQuery();
            }
        }

        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            Department department = new Department();
            department.DepartmentId = Convert.ToInt32(reader["department_id"]);
            department.Name = Convert.ToString(reader["name"]);

            return department;
        }
    }
}
