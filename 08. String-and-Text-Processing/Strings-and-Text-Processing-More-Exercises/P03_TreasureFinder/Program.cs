using System;
using System.Linq;
using System.Text;

namespace P03_TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string message = Console.ReadLine();

            while (message != "find")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < message.Length; i++)
                {

                    if (i > key.Length - 1)
                    {
                        sb.Append((char)(message[i] - key[i % key.Length]));
                    }
                    else
                    {
                        sb.Append((char)(message[i] - key[i]));
                    }

                }

                message = Console.ReadLine();

                string decriptedMessage = sb.ToString();

                int startIndexOfTresure = 0;
                int endIndexOfTresure = 0;

                int startIndexForCoordinates = 0;
                int endIndexForCoordinates = 0;
                for (int i = 0; i < decriptedMessage.Length; i++)
                {
                    if (decriptedMessage[i] == '&')
                    {
                        startIndexOfTresure = i;
                        for (int j = i + 1; j <= decriptedMessage.Length; j++)
                        {
                            if (decriptedMessage[j] == '&')
                            {
                                endIndexOfTresure = j;
                                break;
                            }
                        }
                        break;
                    }
                }
                for (int i = endIndexOfTresure; i <= decriptedMessage.Length; i++)
                {

                    if (decriptedMessage[i] == '<')
                    {
                        startIndexForCoordinates = i;
                        for (int j = i + 1; j <= decriptedMessage.Length; j++)
                        {
                            if (decriptedMessage[j] == '>')
                            {
                                endIndexForCoordinates = j;
                                break;
                            }
                        }
                        break;
                    }
                }

                string tresure = decriptedMessage.Substring(startIndexOfTresure + 1, endIndexOfTresure - startIndexOfTresure-1);
                string coordinates = decriptedMessage.Substring(startIndexForCoordinates + 1, endIndexForCoordinates - startIndexForCoordinates-1);

                Console.WriteLine($"Found {tresure} at {coordinates}");
            }
        }
    }
}
