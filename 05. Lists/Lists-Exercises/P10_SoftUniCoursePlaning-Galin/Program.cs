﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "course start")
                {
                    break;
                }

                string[] tokens = input.Split(":");

                string command = tokens[0];

                if (command == "Add")
                {
                    string lesson = tokens[1];
                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    string lesson = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Insert(index,lesson);
                    }
                }

                else if (command == "Remove")
                {
                    string lesson = tokens[1];
                    int index = lessons.IndexOf(lesson);
                    if (lessons.Contains(lesson))
                    {
                        if (lessons.Contains($"{lesson}-Exercise"))
                        {
                            lessons.RemoveAt(index + 1);
                        }
                        lessons.Remove(lesson);
                    }
                }

                else if (command == "Swap")
                {
                    string firstLesson = tokens[1];
                    string secondLesson = tokens[2];

                    int firstIndex = lessons.IndexOf(firstLesson);
                    int secondIndex = lessons.IndexOf(secondLesson);

                    if (firstIndex == -1 || secondIndex == -1)
                    {
                        continue;
                    }
                    else
                    {
                        lessons[firstIndex] = secondLesson;
                        lessons[secondIndex] = firstLesson;
                        if (lessons.Contains($"{firstLesson}-Exercise"))
                        {                           
                            lessons.RemoveAt(firstIndex + 1);
                            lessons.Insert(secondIndex + 1, $"{firstLesson}-Exercise");
                        }
                        if (lessons.Contains($"{secondLesson}-Exercise"))
                        {
                            lessons.RemoveAt(secondIndex + 1);
                            lessons.Insert(firstIndex + 1, $"{secondLesson}-Exercise");
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string lesson = tokens[1];
                    string exercise = $"{lesson}-Exercise";

                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Add(lesson);
                        lessons.Add(exercise);
                    }
                    if(lesson.Contains(lesson) && lessons.Contains(exercise) == false)
                    {
                        int index = lessons.IndexOf(lesson);
                        lessons.Insert(index + 1, exercise);
                    }
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
        }
    }
}
