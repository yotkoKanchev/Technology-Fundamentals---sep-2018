using System;
using System.Collections.Generic;

namespace P04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("_");
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song()
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time
                };

                songsList.Add(song);
            }

            string argument = Console.ReadLine();

            if (argument == "all")
            {
                foreach (var song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songsList)
                {
                    if (song.TypeList == argument)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
        
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
