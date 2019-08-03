using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            int number = 0;
            int index = 0;
            string condition = string.Empty;
            bool isContains = false;
            int counter = 0;

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
            
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Contains":
                        number = int.Parse(command[1]);
                        foreach (var item in nums)
                        {
                            if (item == number)
                            {
                                isContains = true;
                                break;
                            }
                        }
                        if (isContains == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (var item in nums)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (var item in nums)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (var item in nums)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        number = int.Parse(command[2]);
                        condition = command[1];
                        switch (condition)
                        {
                            case "<":
                                foreach (var item in nums)
                                {
                                    if (item < number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                foreach (var item in nums)
                                {
                                    if (item > number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (var item in nums)
                                {
                                    if (item >= number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (var item in nums)
                                {
                                    if (item <= number)
                                    {
                                        Console.Write(item + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
