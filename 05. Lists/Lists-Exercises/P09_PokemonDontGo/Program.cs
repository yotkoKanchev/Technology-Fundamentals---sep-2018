using System;
using System.Linq;

namespace P02_PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            int indexInteger = int.Parse(Console.ReadLine());
            long sumOfRemovedElements = 0;
            while (inputList.Count > 0)
            {
                long removedElement = 0;
                if (indexInteger < 0)
                {
                    removedElement = inputList[0];
                    sumOfRemovedElements += removedElement;
                    inputList.RemoveAt(0);
                    inputList.Insert(0, inputList[inputList.Count - 1]);

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= removedElement)
                        {
                            inputList[i] += removedElement;
                        }
                        else
                        {
                            inputList[i] -= removedElement;
                        }
                    }
                }
                else if (indexInteger > inputList.Count - 1)
                {
                    removedElement = inputList[inputList.Count - 1];
                    sumOfRemovedElements += removedElement;
                    inputList.RemoveAt(inputList.Count - 1);
                    inputList.Insert(inputList.Count, inputList[0]);

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= removedElement)
                        {
                            inputList[i] += removedElement;
                        }
                        else
                        {
                            inputList[i] -= removedElement;
                        }
                    }
                }
                else
                {
                    removedElement = inputList[indexInteger];
                    sumOfRemovedElements += removedElement;

                    inputList.RemoveAt(indexInteger);
                    if (inputList.Count < 1)
                    {
                        break;
                    }
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] <= removedElement)
                        {
                            inputList[i] += removedElement;
                        }
                        else
                        {
                            inputList[i] -= removedElement;
                        }
                    }
                }

                indexInteger = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
