using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string printOutput = "";

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);
                int numLen = input.Length;
                int digit = (num % 10);

                char letter = ' ';

                switch (digit)
                {
                    case 2:
                        if (numLen == 3)
                        {
                            letter = 'c';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'b';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'a';
                        }
                        break;
                    case 3:
                        if (numLen == 3)
                        {
                            letter = 'f';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'e';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'd';
                        }
                        break;
                    case 4:
                        if (numLen == 3)
                        {
                            letter = 'i';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'h';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'g';
                        }
                        break;
                    case 5:
                        if (numLen == 3)
                        {
                            letter = 'l';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'k';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'j';
                        }
                        break;
                    case 6:
                        if (numLen == 3)
                        {
                            letter = 'o';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'n';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'm';
                        }
                        break;
                    case 7:
                        if (numLen == 4)
                        {
                            letter = 's';
                        }
                        else if (numLen == 3)
                        {
                            letter = 'r';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'q';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'p';
                        }
                        break;
                    case 8:
                        if (numLen == 3)
                        {
                            letter = 'v';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'u';
                        }
                        else if (numLen == 1)
                        {
                            letter = 't';
                        }
                        break;
                    case 9:
                        if (numLen == 4)
                        {
                            letter = 'z';
                        }
                        else if (numLen == 3)
                        {
                            letter = 'y';
                        }
                        else if (numLen == 2)
                        {
                            letter = 'x';
                        }
                        else if (numLen == 1)
                        {
                            letter = 'w';
                        }
                        break;
                    case 0:
                        if (numLen == 1)
                        {
                            letter = ' ';
                        }
                        break;
                    default:
                        break;
                }
                printOutput += letter;
            }
            Console.WriteLine(printOutput);
        }
    }
}
