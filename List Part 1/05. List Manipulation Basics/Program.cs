using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            int number = 0;
            int index = 0;

            while (command[0] != "end")
            {               
                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        nums.Add(number);
                        break;
                    case "Remove":
                        number = int.Parse(command[1]);
                        nums.Remove(number);
                        break;
                    case "RemoveAt":
                        index = int.Parse(command[1]);
                        nums.RemoveAt(index);                        
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        nums.Insert(index, number);
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
