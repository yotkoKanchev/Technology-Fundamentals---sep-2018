using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Dictionary
{   
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            
            string wordsData = Console.ReadLine();

            string[] tokens = wordsData.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                string[] wordTokens = tokens[i].Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string word = wordTokens[0];
                string deff = wordTokens[1];

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(deff);
            }

            string[] wordsTocheck = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();
            if (command == "End")
            {
                foreach (var item in wordsTocheck)
                {
                    if (words.ContainsKey(item))
                    {
                        Console.WriteLine(item);
                        foreach (var kvp in words.Where(x=>x.Key == item))
                        {
                            foreach (var element in kvp.Value.OrderByDescending(x=>x.Count()))
                            {
                                Console.WriteLine($" -{element}");
                            }
                        }
                    }
                }
            }
            else if (command == "List")
            {
                List<string> printList = new List<string>();
                foreach (var kvp in words.OrderBy(x=>x.Key))
                {
                    printList.Add(kvp.Key);
                }

                Console.WriteLine(string.Join(" ",printList));
            }
        }
    }
}
