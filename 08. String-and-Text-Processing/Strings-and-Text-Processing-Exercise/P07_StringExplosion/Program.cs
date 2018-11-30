using System;

namespace P07_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            int askedSymbolIndex = 0;
            int symbolsToRemove = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {

                if (inputLine[i] == '>')
                {
                    askedSymbolIndex = i + 1;
                    symbolsToRemove = int.Parse(inputLine[i + 1].ToString());
                    for (int j = 1; j <= symbolsToRemove; j++)
                    {                        
                        if (inputLine[i] + j != '>')
                        {
                            inputLine.Remove(i + j, 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    inputLine = inputLine.Remove(askedSymbolIndex, symbolsToRemove);                   
                }
            }

            Console.WriteLine(inputLine);
        }
    }
}
