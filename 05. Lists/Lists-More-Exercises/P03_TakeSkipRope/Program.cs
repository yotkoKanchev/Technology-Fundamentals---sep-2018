using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            List<int> digits = new List<int>();
            List<string> characters = new List<string>();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();


            for (int i = 0; i < inputLine.Length; i++)
            {
                if (Char.IsDigit(inputLine[i]))
                {
                    digits.Add(int.Parse(inputLine[i].ToString()));
                }
                else
                {
                    characters.Add(inputLine[i].ToString());
                }
            }

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }
            int counter = 0;
            List<string> resultList = new List<string>();

            for (int i = 0; i < takeList.Count; i++)
            {
                
                for (int j = 0; j < takeList[i]; j++)
                {
                    resultList.Add(characters[counter]);
                    counter++;
                    if (counter > characters.Count-1)
                    {
                        break;
                    }
                }
                for (int k = 0; k < skipList[i]; k++)
                {
                    counter++;
                    if (counter > characters.Count-1)
                    {
                        break;
                    }
                }                
            }
            
            foreach (var item in resultList)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
