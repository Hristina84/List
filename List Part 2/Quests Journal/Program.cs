using System;
using System.Collections.Generic;
using System.Linq;

namespace Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
            var command = Console.ReadLine().Split('-').Select(s => s.Trim()).ToList();
            

            string quest = string.Empty;

            while (command[0] != "Retire!")
            {
                switch (command[0])
                {
                    case "Start":
                        quest = command[1];
                        input = PutStartString(input, quest);
                        break;
                    case "Complete":
                        quest = command[1];
                        input = RemoveQuest(input, quest);
                        break;
                    case "Side Quest":
                        quest = command[1];
                        var subQuest = quest.Split(':').Select(s => s.Trim()).ToList();
                        var word1 = subQuest[0];
                        var sideQuest = subQuest[1];
                        input = PutSideQuest(input, word1, sideQuest);

                        break;
                    case "Renew":
                        quest = command[1];
                        input = PutQuestAtLast(input, quest);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split('-').Select(s => s.Trim()).ToList();
            }
            Console.WriteLine(string.Join(", ", input));
        }

        static List<string> PutSideQuest(List<string> input, string word1, string sideQuest)
        {
            if (input.Contains(word1))
            {

                if (!input.Contains(sideQuest))
                {
                    int index = input.FindIndex(a => a.Contains(word1));
                    input.Insert(index + 1, sideQuest);
                }              
            }
            return input;
        }

        static List<string> PutQuestAtLast(List<string> input, string quest)
        {
            if (input.Contains(quest))
            {
                input.Remove(quest);
                input.Add(quest);
            }
            return input;
        }

        static List<string> RemoveQuest(List<string> input, string quest)
        {
            if (input.Contains(quest))
            {
                input.Remove(quest);
            }
            return input;
        }

        static List<string> PutStartString(List<string> input, string quest)
        {
            if (!input.Contains(quest))
            {
                input.Add(quest);
            }
            return input;
        }
    }
}
