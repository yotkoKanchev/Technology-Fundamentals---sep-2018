using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string inpitLine = Console.ReadLine();

            while (inpitLine != "End")
            {
                string[] tokens = inpitLine.Split();

                Person person = new Person(tokens);

                people.Add(person);

                inpitLine = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
        class Person
        {
            public Person(string[] inputData)
            {
                this.Name = inputData[0];
                this.Id = inputData[1];
                this.Age = int.Parse(inputData[2]);
            }
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
    }
}
