namespace P02_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> bandNamesAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, long> bandNamesAndTimes = new Dictionary<string, long>();

            while (inputLine != "start of concert")
            {
                string[] tokens = inputLine.Split("; ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string bandName = tokens[1];

                if (command == "Add")
                {
                    string allMemebers = tokens[2];
                    string[] members = allMemebers.Split(", ", StringSplitOptions.RemoveEmptyEntries);


                    if (!bandNamesAndMembers.ContainsKey(bandName))
                    {
                        bandNamesAndMembers[bandName] = new List<string>();
                        bandNamesAndTimes[bandName] = 0;

                        foreach (var member in members)
                        {
                            if (!bandNamesAndMembers[bandName].Contains(member))
                            {
                                bandNamesAndMembers[bandName].Add(member);
                            }
                        }
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bandNamesAndMembers[bandName].Contains(member))
                            {
                                bandNamesAndMembers[bandName].Add(member);
                            }
                        }
                    }
                }
                else if (command == "Play")
                {
                    long time = long.Parse(tokens[2]);
                    if (bandNamesAndMembers.ContainsKey(bandName))
                    {
                        bandNamesAndTimes[bandName] += time;
                    }
                    else
                    {
                        bandNamesAndMembers[bandName] = new List<string>();
                        bandNamesAndTimes[bandName] = time;
                    }
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"Total time: {bandNamesAndTimes.Values.Sum()}");
            foreach (var kvp in bandNamesAndTimes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


            string askedBand = Console.ReadLine();

            foreach (var kvp in bandNamesAndMembers.Where(x => x.Key == askedBand))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var member in kvp.Value)
                {
                    Console.WriteLine($"=> {member}");
                }
            }
        }
    }
}
