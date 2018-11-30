using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ListManipulationAdvances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            bool haveChanges = false;
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        double number = double.Parse(tokens[1]);
                        numbers.Add(number);
                        haveChanges = true;
                        break;
                    case "Remove":
                        number = double.Parse(tokens[1]);
                        numbers.Remove(number);
                        haveChanges = true;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index);
                        haveChanges = true;
                        break;
                    case "Insert":
                        number = int.Parse(tokens[1]);
                        index = int.Parse(tokens[2]);
                        numbers.Insert(index, number);
                        haveChanges = true;
                        break;
                    case "Contains":
                        number = double.Parse(tokens[1]);
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        int evenOrOdd = 1;
                        PrintEvenOrOddNumbers(numbers, evenOrOdd);
                        break;
                    case "PrintOdd":
                        evenOrOdd = -1;
                        PrintEvenOrOddNumbers(numbers, evenOrOdd);
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = inputLine.Split()[1];
                        int num = int.Parse(inputLine.Split()[2]);
                        FilterNumbers(numbers, num, condition);
                        break;
                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }
            if (haveChanges == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        public static void FilterNumbers(List<double> myList, double num, string condition)
        {
            List<double> resultList = new List<double>();
            if (condition == "<=")
            {
                foreach (var item in myList)
                {
                    if (item <= num)
                    {
                        resultList.Add(item);
                    }
                }
            }
            else if (condition == ">=")
            {
                foreach (var item in myList)
                {
                    if (item >= num)
                    {
                        resultList.Add(item);
                    }
                }
            }

            else if (condition == ">")
            {
                foreach (var item in myList)
                {
                    if (item > num)
                    {
                        resultList.Add(item);
                    }
                }
            }
            else if (condition == "<")
            {
                foreach (var item in myList)
                {
                    if (item < num)
                    {
                        resultList.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }

        public static void PrintEvenOrOddNumbers(List<double> myList, int EvenOrOdd)
        {
            List<double> resultList = new List<double>();
            if (EvenOrOdd == 1)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] % 2 == 0)
                    {
                        resultList.Add(myList[i]);
                    }
                }
            }
            else if (EvenOrOdd == -1)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] % 2 != 0)
                    {
                        resultList.Add(myList[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultList));

        }
    }
}
