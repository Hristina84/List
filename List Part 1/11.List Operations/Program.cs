using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            int number = 0;
            int index = 0;
            int count = 0;

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        nums.Add(number);
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);

                        if (index > nums.Count - 1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.RemoveAt(index);
                        }
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);

                        if (index > nums.Count - 1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(index, number);
                        }
                        break;
                    case "Shift":
                        count = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int j = 0; j < count; j++)
                            {
                                int end = nums[0];

                                for (int i = 0; i < nums.Count - 1; i++)
                                {
                                    nums[i] = nums[i + 1];
                                }
                                nums[nums.Count - 1] = end;
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int j = 0; j < count; j++)
                            {
                                int start = nums[nums.Count - 1];

                                for (int i = nums.Count - 1; i > 0; i--)
                                {
                                    nums[i] = nums[i - 1];
                                }
                                nums[0] = start;
                            }
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
