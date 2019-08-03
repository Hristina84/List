using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long number = 0;
            long sum = 0;

            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());              
                
                if (index < 0)
                {
                    number = input[0];
                    input[0] = input[input.Count - 1];                    
                }
                else if (index > input.Count - 1)
                {
                    number = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
                }
                else 
                {
                    number = input[index];
                    input.RemoveAt(index);
                } 
                sum += number;

                for (int i = 0; i < input.Count ; i++)
                {
                    if (input[i] > number)
                    { input[i] -= number; }

                    else if (input[i] <= number)
                    { input[i] += number; }
                }                
            }
            Console.WriteLine(sum);
        }
    }
}
