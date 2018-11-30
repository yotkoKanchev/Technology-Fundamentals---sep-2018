using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeamsToRegister = int.Parse(Console.ReadLine());
            
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeamsToRegister; i++)
            {
                List<string> teamMembers = new List<string>();

                string inputData = Console.ReadLine();

                string teamName = inputData.Split("-")[1];
                string creator = inputData.Split("-")[0];

                Team team = new Team(teamName, creator);
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.CreatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else 
                {
                    team.TeamName = teamName;
                    team.CreatorName = creator;
                    team.Members = teamMembers;

                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            
            string inputLine = Console.ReadLine();

            while (inputLine != "end of assignment")
            {
                string[] tokens = inputLine.Split("->");

                string nameToJoin = tokens[0];
                string teamToJoin = tokens[1];
                if (!teams.Any(x => x.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    if (teams.Any(x => x.Members.Contains(nameToJoin) || x.CreatorName == nameToJoin))
                    {
                        Console.WriteLine($"Member {nameToJoin} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        teams.Single(x => x.TeamName == teamToJoin).Members.Add(nameToJoin);
                    }
                }      

                inputLine = Console.ReadLine();
            }

            foreach (var team in teams.Where(x=>x.Members.Count > 0).OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(m=>m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x=>x.Members.Count == 0).OrderBy(x=>x.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }

        class Team
        {
            public Team(string teamName, string creatorName)
            {
                this.TeamName = teamName;
                this.CreatorName = creatorName;
                this.Members = new List<string>();
            }
            public string TeamName { get; set; }
            public string CreatorName { get; set; }
            public List<string> Members { get; set; }
        }
    }
}
