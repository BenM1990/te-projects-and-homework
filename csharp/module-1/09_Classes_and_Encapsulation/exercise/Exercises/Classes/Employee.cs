namespace Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }

        public void RaiseSalary(double percent)
        {
            AnnualSalary += (AnnualSalary * (percent / 100));
        }

        
        
    
    }


}
