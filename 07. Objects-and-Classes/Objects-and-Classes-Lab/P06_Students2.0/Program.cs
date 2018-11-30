using System;
using System.Collections.Generic;

namespace P06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var projects = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("-");
                string creatorName = tokens[0];
                string teamToCreate = tokens[1];

                if (!projects.ContainsKey(teamToCreate))
                {
                    if (!projects.Values))
                    {

                    }
                }
            }
        }
    }
}
