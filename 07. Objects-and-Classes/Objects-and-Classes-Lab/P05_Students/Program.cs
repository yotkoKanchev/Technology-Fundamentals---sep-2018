using System;
using System.Collections.Generic;

namespace P05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            List<Student> studentsList = new List<Student>();
            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };

                studentsList.Add(student);
                inputLine = Console.ReadLine();
            }

            string askedCity = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (student.HomeTown == askedCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
