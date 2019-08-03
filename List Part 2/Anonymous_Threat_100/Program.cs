using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat_100
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            {
                var split = command.Split();
                switch (split[0])
                {
                    case "merge":
                        input = Merge(input, int.Parse(split[1]), int.Parse(split[2]));
                        break;

                    case "divide":
                        input = Divide(input, int.Parse(split[1]), int.Parse(split[2]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static string[] Merge(string[] input, int startIndex, int endIndex)
        {
            string merged = string.Empty;
            if (startIndex < 0)
                startIndex = 0;
            if (endIndex >= input.Length)
                endIndex = input.Length - 1;
            for (int i = startIndex; i <= endIndex; i++)
                merged += input[i];
            return input.Take(startIndex).Concat(new[] { merged }).Concat(input.Skip(endIndex + 1)).ToArray();
        }

        static string[] Divide(string[] input, int index, int partitions)
        {
            string element = input[index];
            int partitionLength = element.Length / partitions;
            var divided = new string[partitions];
            for (int i = 0; element.Length > partitionLength; i++)
            {
                divided[i] = element.Substring(0, partitionLength);
                element = element.Substring(partitionLength);
            }
            divided[partitions - 1] += element;
            return input.Take(index).Concat(divided).Concat(input.Skip(index + 1)).ToArray();
        }
    }
}
