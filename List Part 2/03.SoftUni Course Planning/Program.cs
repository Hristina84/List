using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
            var command = Console.ReadLine().Split(':').ToList();

            while (command[0] != "course start")
            {
                string lessonTitle = command[1];

                switch (command[0])
                {
                    case "Add":
                        input = Add(input, lessonTitle);
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);
                        input = Insert(input, lessonTitle, index);
                        break;
                    case "Remove":
                        input = Remove(input, lessonTitle);
                        break;
                    case "Swap":
                        string lessonTitle2 = command[2];
                        input = Swap(input, lessonTitle, lessonTitle2);
                        break;
                    case "Exercise":
                        input = InsertExercise(input, lessonTitle);
                        break;
                }
                command = Console.ReadLine().Split(':').ToList();
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }

        static List<string> InsertExercise(List<string> input, string lessonTitle)
        {
            if (input.Contains(lessonTitle + "-Exercise"))
            {
                return input;
            }
            else if (input.Contains(lessonTitle) && !input.Contains(lessonTitle + "-Exercise"))
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == lessonTitle)
                    {
                        input.Insert(i + 1, lessonTitle + "-Exercise");
                    }
                }
            }
            else if (!input.Contains(lessonTitle))
            {
                input.Add(lessonTitle);
                input.Add(lessonTitle + "-Exercise");
            }
            return input;
        }

        static List<string> Swap(List<string> input, string lessonTitle, string lessonTitle2)
        {
            if (input.Contains(lessonTitle) && input.Contains(lessonTitle2))
            {
                int indexOfLessonTitle = input.FindIndex(a => a.Contains(lessonTitle));
                int indexOfLessonTitle2 = input.FindIndex(a => a.Contains(lessonTitle2));

                string temp = input[indexOfLessonTitle];
                input[indexOfLessonTitle] = input[indexOfLessonTitle2];
                input[indexOfLessonTitle2] = temp;

                if (input.Contains(lessonTitle + "-Exercise"))
                {
                    input.Remove(lessonTitle + "-Exercise");
                    input.Insert(indexOfLessonTitle2 + 1, lessonTitle + "-Exercise");
                }
                if (input.Contains(lessonTitle2 + "-Exercise"))
                {
                    input.Remove(lessonTitle2 + "-Exercise");
                    input.Insert(indexOfLessonTitle + 1, lessonTitle2 + "-Exercise");
                }
            }
            return input;
        }

        static List<string> Remove(List<string> input, string lessonTitle)
        {
            if (input.Contains(lessonTitle))
            {
                input.Remove(lessonTitle);

                if (input.Contains(lessonTitle + "-Exercise"))
                {
                    input.Remove(lessonTitle + "-Exercise");
                }
            }
            return input;
        }

        static List<string> Insert(List<string> input, string lessonTitle, int index)
        {
            if (!input.Contains(lessonTitle))
            {
                input.Insert(index, lessonTitle);
            }
            return input;
        }

        static List<string> Add(List<string> input, string lessonTitle)
        {
            if (!input.Contains(lessonTitle))
            {
                input.Add(lessonTitle);
            }
            return input;
        }
    }
}
