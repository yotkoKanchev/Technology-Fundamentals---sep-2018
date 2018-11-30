using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();                

            string inputLine = Console.ReadLine();

            while (inputLine != "Retire!")
            {
                string[] tokens = inputLine.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Start":
                        string quest = tokens[1];

                        if (!journal.Contains(quest))
                        {
                            journal.Add(quest);
                        }
                        break;

                    case "Complete":
                        quest = tokens[1];
                        if (journal.Contains(quest))
                        {
                            journal.Remove(quest);
                        }
                        break;

                    case "Side Quest":
                        string[] arguments = tokens[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                        quest = arguments[0];
                        string sideQuest = arguments[1];
                        if (journal.Contains(quest) && journal.Contains(sideQuest) == false)
                        {
                            journal.Insert(journal.IndexOf(quest)+1, sideQuest);
                        }

                        break;

                    case "Renew":
                        quest = tokens[1];

                        if (journal.Contains(quest))
                        {
                            journal.Remove(quest);
                            journal.Add(quest);
                        }
                        break;                   
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",journal));
        }
    }
}
