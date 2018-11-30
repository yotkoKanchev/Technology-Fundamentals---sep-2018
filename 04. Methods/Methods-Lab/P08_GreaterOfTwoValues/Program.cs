using System;

namespace P08_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(firstValue), int.Parse(secondValue))); 
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(firstValue), char.Parse(secondValue)));
                    break;
                case "string":
                    Console.WriteLine(GetMax(firstValue, secondValue));
                    break;
            }
        }
        private static int GetMax(int firstNum, int secondNum)
        {
            int result = 0;
            if (firstNum > secondNum)
            {
                result = firstNum;
            }
            else
            {
                result = secondNum;
            }
            return result;
        }

        private static char GetMax(char firstSimbol, char secondSymbol)
        {
            char result = (char)0;

            if (firstSimbol>secondSymbol)
            {
                result = firstSimbol;
            }
            else
            {
                result = secondSymbol;
            }
            return (char)result;
        }

        private static string GetMax(string firstString, string secondString)
        {
            string resultString = string.Empty;
            int result = 0;

            result = String.Compare(firstString, secondString);

            if (result > 0)
            {
                resultString = firstString; 
            }
            else
            {
                resultString = secondString;
            }
            return resultString;
        }
    }
}
