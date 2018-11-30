using System;

namespace P02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random newRandom = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = newRandom.Next(0, words.Length);

                string tempWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = tempWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
