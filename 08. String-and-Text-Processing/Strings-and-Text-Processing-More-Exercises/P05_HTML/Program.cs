using System;

namespace P05_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();

            string inputLine = Console.ReadLine();
            Console.WriteLine($"<h1>\n\t{title}\n</h1>");
            Console.WriteLine($"<article>\n\t{article}\n</article>");
            while (inputLine != "end of comments")
            {
                Console.WriteLine($"<div>\n\t{inputLine}\n</div>");


                inputLine = Console.ReadLine();
            }
        }
    }
}
