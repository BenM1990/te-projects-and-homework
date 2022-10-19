using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();
            using (SqlConnection employeeConnection = new SqlConnection(connectionString))
            {
                employeeConnection.Open();
                SqlCommand employeeCommand = new SqlCommand("SELECT * FROM employee", employeeConnection);


                SqlDataReader reader = employeeCommand.ExecuteReader(); // exectue the select query


                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd;

                if((firstNameSearch == "" || firstNameSearch == null) && (lastNameSearch == "" || lastNameSearch == null))
                {
                    cmd = new SqlCommand("SELECT * FROM employee", conn);
                }
                if (firstNameSearch == "" || firstNameSearch == null)
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE last_name LIKE @lastNameSearch", conn);
                    string lastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", lastName);
                }
                if (lastNameSearch == "" || firstNameSearch == null)
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE first_name LIKE @firstNameSearch", conn);
                    string firstName = ("%" + firstNameSearch + "%");
                    cmd.Parameters.AddWithValue("@firstNameSearch", firstName);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM employee WHERE first_name LIKE @firstNameSearch AND last_name LIKE @lastNameSearch", conn);
                    string firstName = ("%" + firstNameSearch + "%");
                    cmd.Parameters.AddWithValue("@firstNameSearch", firstName);
                    string lastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", lastName);
                }

         
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
                
            }
            return employees;

        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> employees = new List<Employee>();
            using (SqlConnection employeeConnection = new SqlConnection(connectionString))
            {
                employeeConnection.Open();
                SqlCommand employeeCommand = new SqlCommand("SELECT * FROM employee JOIN project_employee ON project_employee.employee_id = employee.employee_id WHERE project_id = @project_id", employeeConnection);
                employeeCommand.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = employeeCommand.ExecuteReader();

                //create park object(s) from the data comming back from the reader
                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO project_employee(project_id, employee_id) VALUES (@project_id, @employee_id);", conn);
                cmd.Parameters.AddWithValue("project_id", projectId);
                cmd.Parameters.AddWithValue("employee_id", employeeId);

                cmd.ExecuteNonQuery();

            }
        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;", conn);
                cmd.Parameters.AddWithValue("project_id", projectId);
                cmd.Parameters.AddWithValue("employee_id", employeeId);

                cmd.ExecuteNonQuery();

            }
        }

        public IList<Employee> GetEmployeesWithoutProjects()
        {
            IList<Employee> employees = new List<Employee>();
            using (SqlConnection employeeConnection = new SqlConnection(connectionString))
            {
                employeeConnection.Open();
                SqlCommand employeeCommand = new SqlCommand("SELECT * FROM employee LEFT JOIN project_employee ON project_employee.employee_id = employee.employee_id WHERE project_id IS NULL;", employeeConnection);
                
                SqlDataReader reader = employeeCommand.ExecuteReader();

               
                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;
        }

        private Employee CreateEmployeeFromReader(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return employee;
        }

    }
}
