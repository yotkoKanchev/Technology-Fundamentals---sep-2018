namespace P02_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string artistPattern = @"^([A-Z][a-z'\s]+)(?=\:)";
            string songPattern = @"(?<=:)([A-Z]+[\s]*)+$";

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                Match artistMatch = Regex.Match(inputLine, artistPattern);
                Match songMatch = Regex.Match(inputLine, songPattern);

                string resultString = string.Empty;

                if (artistMatch.Success && songMatch.Success)
                {
                    string artist = artistMatch.ToString();
                    string song = songMatch.ToString();

                    int key = artist.Length;

                    foreach (var symbol in inputLine)
                    {
                        if (char.IsLetter(symbol))
                        {
                            if (char.IsLower(symbol))
                            {
                                if ((char)(symbol + key) > 'z')
                                {
                                    resultString += (char)('a' + ((symbol+key) - 'z' - 1));
                                }
                                else
                                {
                                    resultString += (char)(symbol + key);
                                }
                            }
                            else if (char.IsUpper(symbol))
                            {
                                if ((char)(symbol + key) > 'Z')
                                {
                                    resultString += (char)('A' + ((symbol + key) - 'Z' -1 ));
                                }
                                else
                                {
                                    resultString += (char)(symbol + key);
                                }
                            }
                            else
                            {
                                resultString += (char)(symbol + key);
                            }
                        }
                        else if (symbol == ':')
                        {
                            resultString += '@';
                        }
                        else
                        {
                            resultString += symbol;
                        }
                    }

                    Console.WriteLine($"Successful encryption: {resultString}");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
