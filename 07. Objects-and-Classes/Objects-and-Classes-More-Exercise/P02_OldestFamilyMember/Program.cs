using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                family.AdMember(tokens);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
        class Person
        {
            public Person(string[] inputArguments)
            {
                this.Name = inputArguments[0];
                this.Age = int.Parse(inputArguments[1]);
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }        

        class Family
        {
            List<Person> FamilyMemebers { get; set; } = new List<Person>();

            public void AdMember(string[] personData)
            {
                Person newMember = new Person(personData);
                FamilyMemebers.Add(newMember);
            }

            public Person GetOldestMember()
            {
                return FamilyMemebers.OrderByDescending(x => x.Age).First();
            }
        }
    }
}
