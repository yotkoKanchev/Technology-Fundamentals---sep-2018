using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(", ")
                .ToList();

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                if (word.Length < 3 || word.Length > 16)
                {
                    words.RemoveAt(i);
                    i--;
                }
                else
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (char.IsLetterOrDigit(words[i][j]) || words[i][j] == '_' || words[i][j] == '-')
                        {

                        }
                        else
                        {
                            words.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
