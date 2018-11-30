using System;
using System.Collections.Generic;

namespace P04_MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morses = new Dictionary<string, string>();

            morses["A"] = ".-";
            morses["B"] = "-...";
            morses["C"] = "-.-.";
            morses["D"] = "-..";
            morses["E"] = ".";
            morses["F"] = "..-.";
            morses["G"] = "--.";
            morses["H"] = "....";
            morses["I"] = "..";
            morses["J"] = ".---";
            morses["K"] = "-.-";
            morses["L"] = ".-..";
            morses["M"] = "--";
            morses["N"] = "-.";
            morses["O"] = "---";
            morses["P"] = ".--.";
            morses["Q"] = "--.-";
            morses["R"] = ".-.";
            morses["S"] = "...";
            morses["T"] = "-";
            morses["U"] = "..-";
            morses["V"] = "...-";
            morses["W"] = ".--";
            morses["X"] = "-..-";
            morses["Y"] = "-.--";
            morses["Z"] = "--..";

            string inputLine = Console.ReadLine();
            string[] words = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in morses)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == kvp.Value)
                    {
                        words[i] = kvp.Key;
                    }
                }                 
            }

            string resultString = "";

            for (int i = 0; i < words.Length; i++)
            {
                resultString += words[i];
            }
            resultString = resultString.Replace('|', ' ');
            Console.WriteLine(resultString);
        }
    }
}
