using System;
using System.Linq;

namespace _10._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            
            int[] bugsField = new int[sizeOfTheField];
            int[] bugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var bug in bugsIndexes)
            {
                if (bug < bugsField.Length && bug > -1)
                {
                    bugsField[bug] = 1;
                }
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();
                long ladybugIndex = 0;
                string direction = string.Empty;
                long flylength = 0;
              
                if (int.Parse(tokens[0]) > -1 && int.Parse(tokens[0]) < sizeOfTheField && (tokens[1] == "left" ||
                    tokens[1] == "right") && int.Parse(tokens[2]) != 0)
                {
                    ladybugIndex = long.Parse(tokens[0]);
                    direction = tokens[1];
                    flylength = long.Parse(tokens[2]);
                }            

                if (flylength < 0 && direction == "left")
                {
                    direction = "right";
                    flylength = Math.Abs(flylength);
                }
                else if (flylength < 0 && direction == "right")
                {
                    direction = "left";
                    flylength = Math.Abs(flylength);
                }
                switch (direction)
                {
                    case "right":

                        if (bugsField[ladybugIndex] == 1)
                        {
                            bugsField[ladybugIndex] = 0;
                        }
                        else
                        {
                            break;
                        }

                        for (long i = ladybugIndex; i < bugsField.Length; i += flylength)
                        {          
                            if (i + flylength < bugsField.Length)
                            {
                                if (bugsField[i + flylength] == 0)
                                {
                                    bugsField[i + flylength] = 1;
                                    break;
                                }
                                else if (bugsField[i + flylength] == 1)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;

                    case "left":
                        if (bugsField[ladybugIndex] == 1)
                        {
                            bugsField[ladybugIndex] = 0;
                        }
                        else
                        {
                            break;
                        }

                        for (long i = ladybugIndex; i >= 0; i-=flylength)
                        {             
                            if (i - flylength > -1)
                            {
                                if (bugsField[i-flylength] == 0)
                                {
                                    bugsField[i - flylength] = 1;
                                    break;
                                }
                                else if (bugsField[i - flylength] == 1)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                }               
                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", bugsField));
        }
    }
}
