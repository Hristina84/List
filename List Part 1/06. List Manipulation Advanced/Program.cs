using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            long number = 0;
            string condition = string.Empty;
            bool isContains = false;

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Contains":
                        number = long.Parse(command[1]);
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
                        long sum = 0;
                        foreach (var item in nums)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        number = long.Parse(command[2]);
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

        }
    }
}
