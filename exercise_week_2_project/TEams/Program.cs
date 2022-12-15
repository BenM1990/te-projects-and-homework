using System;
using System.Collections.Generic;

namespace TEams
{
    class Program
    {
        public Dictionary<string, Project> projects { get; set; }

        public List<Department> departments;
        public List<Employee> employees;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            // create some departments
            CreateDepartments();


            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
            departments = new List<Department>();
            departments.Add(new Department(1, "Marketing"));
            departments.Add(new Department(2, "Sales"));
            departments.Add(new Department(3, "Engineering"));
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach (var dep in departments)
            {
                Console.WriteLine(dep.Name);
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {
            DateTime today = DateTime.Today;
            employees = new List<Employee>();
            Employee employeeDean = new Employee();

            employeeDean.EmployeeId = 1;
            employeeDean.FirstName = "Dean";
            employeeDean.LastName = "Johnson";
            employeeDean.Email = "djohnson@teams.com";
            employeeDean.Department = GetDepartmentByName("Engineering");
            employeeDean.HireDate = today;

            employees.Add(employeeDean);
            employees.Add(new Employee(2, "Angie", "Smith", "asmith@teams.com", GetDepartmentByName("Engineering"), today));
            employees.Add(new Employee(3, "Margaret", "Thompson", "mthompson@teams", GetDepartmentByName("Marketing"), today));
            employees[1].RaisedSalary(10);
        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FullName} ({emp.Salary:C2}) {emp.Department.Name}");
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {
            projects = new Dictionary<string, Project>();
            {
                Project newProject = new Project("TEams", "Project Managment Software", DateTime.Today, DateTime.Today.AddDays(30));

                newProject.TeamMembers = new List<Employee>();
                newProject.TeamMembers.Add(employees[0]);
                newProject.TeamMembers.Add(employees[1]);

                projects.Add("TEams", newProject);
            }
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {
            Project newProject = new Project("Marketing Landing Page", "Lead Capture Landing Page for Marketing", DateTime.Today.AddDays(31), DateTime.Today.AddDays(38));

            newProject.TeamMembers = new List<Employee>();
            newProject.TeamMembers.Add(employees[2]);

            projects.Add("Marketing Landing Page", newProject);
        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            foreach (var pro in projects)
            {
                Console.WriteLine($"{pro.Key}: {pro.Value.TeamMembers.Count}");
            }
        }

        private Department GetDepartmentByName(string _dep)
        {
            foreach (var dep in departments)
            {
                if (dep.Name == _dep)
                {
                    return dep;
                }
            }
            return null;
        }
    }
}