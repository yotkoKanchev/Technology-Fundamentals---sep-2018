using System;
using System.Linq;

namespace P10_WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                char[] winningSymbols = new char[4]{'@', '#', '$', '^' };

                string leftSide = ticket.Substring(0, 10);
                int leftCount = 1;
                char leftSymbol = ' ';

                for (int j = 0; j < winningSymbols.Length; j++)
                {
                    leftCount = 1;
                    for (int k = 0; k < leftSide.Length-1; k++)
                    {
                        if (leftSide[k] == leftSide[k+1] && leftSide[k] == winningSymbols[j])
                        {
                            leftCount++;
                            if (leftCount>=6)
                            {
                                leftSymbol = winningSymbols[j];
                            }
                        }
                    }
                    
                    if (leftCount>=6)
                    {
                        break;
                    }
                }
                
                string rightSide = ticket.Substring(10);                                
                int rightCount = 1;
                char rightSymbol = '~';

                for (int j = 0; j < winningSymbols.Length; j++)
                {
                    rightCount = 1;
                    for (int k = 0; k < rightSide.Length - 1; k++)
                    {
                        if (rightSide[k] == rightSide[k + 1] && rightSide[k] == winningSymbols[j])
                        {
                            rightCount++;
                            if (rightCount >= 6)
                            {
                                rightSymbol = winningSymbols[j];
                            }
                        }
                    }
                    
                    if (rightCount >= 6)
                    {
                        break;
                    }
                }
                
                if (leftSymbol == rightSymbol && rightCount > 5 && leftCount > 5)
                {
                    if (leftCount == 10 && rightCount == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{leftSymbol} Jackpot!");
                    }
                    else 
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftCount, rightCount)}{leftSymbol}");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }
            }
        }
    }
}
