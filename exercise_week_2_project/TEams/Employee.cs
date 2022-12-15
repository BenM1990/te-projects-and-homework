using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } 
        public Department Department { get; set; }
        public DateTime HireDate { get; set; }

        public const double DefaultSalary = 60000.00;
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public Employee( long employeeId, string firstName, string lastName, string email, Department department, DateTime hireDate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            HireDate = hireDate;
            Salary = DefaultSalary;
        }

        public Employee()
        {
            Salary = DefaultSalary;
        }
         
        public void RaisedSalary(double percent)
        {
            Salary += Salary * percent / 100;
        }


    }
}