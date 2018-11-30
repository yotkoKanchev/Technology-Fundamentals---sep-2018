using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] splitedInput = Console.ReadLine()
                    .Split("-");

                string creatorName = splitedInput[0];
                string teamName = splitedInput[1];

                bool isTeamNameExist = teams.Any(x => x.Name == teamName);                
                bool isCreatorNameExist = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamNameExist == false && isCreatorNameExist == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNameExist)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] splitedInput = input.Split("->");
                string user = splitedInput[0];
                string teamName = splitedInput[1];

                bool isTeamExist = teams.Any(x => x.Name == teamName);
                bool isAlreadyMemeber = teams.Any(x => x.Memebers.Contains(user) || x.CreatorName == user);

                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (isAlreadyMemeber)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                if (isTeamExist && isAlreadyMemeber == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Memebers.Add(user);
                }
            }
            List<Team> teamsWithMemebers = teams
                .Where(x => x.Memebers.Count > 0)
                .OrderByDescending(x=>x.Memebers.Count)
                .ThenBy(x=>x.Name)
                .ToList();

            List<Team> teamsWithoutMemebers = teams
                .Where(x => x.Memebers.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var team in teamsWithMemebers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.CreatorName);
                Console.WriteLine(string.Join(Environment.NewLine,team.Memebers.Select(x=> $"-- {x}")));
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWithoutMemebers)
            {
                Console.WriteLine(team.Name);
            }
        }

        class Team
        { 
            public Team(string name, string creatorName)
            {
                Name = name;
                CreatorName = creatorName;
                Memebers = new List<string>();
            }

            public string Name { get; set; }
            public string CreatorName{ get; set; }
            public List<string> Memebers { get; set; }
        }
    }
}
