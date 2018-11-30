using System;

namespace P03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string workString = Console.ReadLine();

            int lastIndexOfSlash = workString.LastIndexOf('\\');

            string nameAndExtension = workString.Substring(lastIndexOfSlash+1);

            string[] clearData = nameAndExtension.Split(".");

            Console.WriteLine($"File name: {clearData[0]}");
            Console.WriteLine($"File extension: {clearData[1]}");
        }
    }
}
