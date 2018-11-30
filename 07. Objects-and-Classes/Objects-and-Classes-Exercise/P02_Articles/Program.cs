using System;

namespace P02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split(", ");
            string title = arguments[0];
            string content = arguments[1];
            string author = arguments[2];

            Article article = new Article(title, content, author);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");

                string command = tokens[0];

                switch (command)
                {
                    case "Edit":
                        article.Edit(tokens[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(tokens[1]);
                        break;
                    case "Rename":
                        article.Rename(tokens[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string newContent)
            {
                Content = newContent;   
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }
}
