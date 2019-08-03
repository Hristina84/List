using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            int startIndex = 0;
            int endIndex = 0;           
            string result = string.Empty;
            var newResult = new List<string>();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);
                    if (startIndex < 0)
                        startIndex = 0;

                    if (endIndex > input.Count - 1)
                        endIndex = input.Count - 1;

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        result += input[i];
                        input.Remove(input[i]);
                    }
                    input.Insert(startIndex, result);
                }

                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
