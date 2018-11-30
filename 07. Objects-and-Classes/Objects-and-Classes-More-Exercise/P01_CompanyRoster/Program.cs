using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P01_CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string deparementName = tokens[2];
                if (!departments.Any(x=>x.DepartmentName == deparementName))
                {
                    List<Employee> employees = new List<Employee>();
                    Employee employee = new Employee(tokens);
                    employees.Add(employee);

                    Department department = new Department(tokens, employees);
                    department.TotalSalaries += double.Parse(tokens[1]);
                    departments.Add(department);                    
                }

                else
                {
                    departments.Find(x => x.DepartmentName == deparementName).workersList.Add(new Employee(tokens));
                    departments.Find(x => x.DepartmentName == deparementName).TotalSalaries += double.Parse(tokens[1]);
                }               
            }
            Department bestDepartment = departments.OrderByDescending(x => x.TotalSalaries / x.workersList.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var worker in bestDepartment.workersList.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{worker.Name} {worker.Salary:f2}");
            }
        }

        class Employee
        {
            public Employee(string[] inputData)
            {
                this.Name = inputData[0];
                this.Salary = double.Parse(inputData[1]);
            }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        class Department
        {
            public Department(string[] inputData, List<Employee> employees)
            {
                this.DepartmentName = inputData[2];
                this.workersList = employees;
            }
            public string DepartmentName { get; set; }
            public List<Employee> workersList { get; set; }
            public double TotalSalaries { get; set; }         
        }
    }
}

