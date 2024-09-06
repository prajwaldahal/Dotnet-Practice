using System;
using System.Linq;
using System.Collections.Generic;

namespace EmployeeList
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initializing a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Raju", Age = 30, Address = "New York", Salary = 50000 },
                new Employee { Id = 102, Name = "Suresh", Age = 35, Address = "Los Angeles", Salary = 52000 },
                new Employee { Id = 103, Name = "Ram", Age = 40, Address = "Houston", Salary = 52000 },
                new Employee { Id = 104, Name = "Ravi", Age = 28, Address = "Chicago", Salary = 45000 },
                new Employee { Id = 105, Name = "John", Age = 32, Address = "New Jersey", Salary = 52000 }
            };

            // LINQ query to select name and address of employees whose name starts with 'R' and age greater than 25 in descending order based on age
            var query1 = from emp in employees
                         where emp.Name.StartsWith("R") && emp.Age > 25
                         orderby emp.Age descending
                         select new { emp.Name, emp.Address };

            Console.WriteLine("Name and Address of employees whose name starts with 'R' and age greater than 25 in descending order based on age");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (var emp in query1)
            {
                Console.WriteLine("Name: " + emp.Name + ", Address: " + emp.Address);
            }

            // LINQ query to select all records of employee whose salary is maximum
            var query3 = (from emp in employees
                          where emp.Salary == employees.Max(e => e.Salary)
                          select emp);
            Console.WriteLine("\nRecord of employee whose salary is maximum");
            Console.WriteLine("-------------------------------------------------------------");
			foreach(var query2 in query3){
            Console.WriteLine("Id: " + query2.Id + ", Name: " + query2.Name + ", Age: " + query2.Age + ", Address: " + query2.Address + ", Salary: " + query2.Salary);}
        }
    }
}
