using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            int startIndex = 0;
            int endIndex = 0;
            int index = 0;
            int partitions = 0;

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    string merged = string.Empty;

                    startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                        startIndex = 0;

                    if (endIndex >= input.Count)
                        endIndex = input.Count - 1;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged += input[i];
                    }
                    input = input.Take(startIndex).Concat(new[] { merged }).Concat(input.Skip(endIndex + 1)).ToList();

                }
                else if (command[0] == "divide")
                {
                    index = int.Parse(command[1]);
                    partitions = int.Parse(command[2]);
                    string textForDividing = input[index];
                    var devided = new string[partitions];
                    int n = textForDividing.Length / partitions;

                    for (int i = 0; i < textForDividing.Length; i++)
                    {
                        devided[i] += textForDividing.Substring(0, n);
                        textForDividing = textForDividing.Substring(n);
                    }
                    devided[devided.Length - 1] = textForDividing;
                    input = input.Take(index).Concat(devided).Concat(input.Skip(index + 1)).ToList();

                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
