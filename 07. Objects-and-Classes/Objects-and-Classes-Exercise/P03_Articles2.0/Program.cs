using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                Article article = new Article(tokens);

                articles.Add(article);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x=>x.Title)));
                    break;
                case "content":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x => x.Content)));
                    break;
                case "author":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x => x.Author)));
                    break;
            }

        }

        class Article
        {
            public Article(string[] inputData)
            {
                this.Title = inputData[0];
                this.Content = inputData[1];
                this.Author = inputData[2];
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
