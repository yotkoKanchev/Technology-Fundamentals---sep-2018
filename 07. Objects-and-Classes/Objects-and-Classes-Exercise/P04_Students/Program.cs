using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                Student student = new Student(tokens);

                students.Add(student);
            }
            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }

        class Student
        {
            public Student(string[] arguments)
                {
                this.FirtName = arguments[0];
                this.LastName = arguments[1];
                this.Grade = double.Parse(arguments[2]);
            }
            public string FirtName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirtName} {this.LastName}: {this.Grade:f2}";
            }
        }
    }
}
