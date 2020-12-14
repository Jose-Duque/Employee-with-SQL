using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Employee_SQL.Entities;

namespace Employee_SQL {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Enter with data the employee:");
            for (int i = 1; i <= 5; i++) {
                Console.Write("Name, E-mail, Salary : ");
                string[] list = Console.ReadLine().Split(',');
                string name = list[0];
                string email = list[1];
                double salary = double.Parse(list[3], CultureInfo.InvariantCulture);

                employees.Add(new Employee(name, email, salary));
            }

            Console.Write("Enter with salary: ");
            int sl = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var emp = employees.Where(employee => employee.Salary > sl).Select(employee => employee.Email);

            var emp2 = employees.Where(employee => employee.Name[0] == 'M').Sum(employee => employee.Salary);

            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            foreach (string employee in emp) {
                
                Console.WriteLine(emp);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M' : " + emp2);
           
        }
    }
                
}
