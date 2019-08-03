using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            long sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    if (bomb[1] == 0)
                    {
                        numbers.RemoveAll(item => item == bomb[0]);
                        break;
                    }
                    if (bomb[1] > numbers.Count)
                    {
                        sum = 0;
                        return;
                    }                    
                    if (i >= bomb[1] && i + bomb[1] <= numbers.Count - 1)
                    {
                        for (int j = i - bomb[1]; j <= i + bomb[1]; j++)
                        {
                            numbers[j] = -1000;
                        }
                    }
                    else if (i < bomb[1] && i + bomb[1] <= numbers.Count - 1)
                    {
                        for (int j = 0; j <= i + bomb[1]; j++)
                        {
                            numbers[j] = -1000;
                        }
                    }
                    else if (i >= bomb[1] && i + bomb[1] > numbers.Count - 1)
                    {
                        for (int j = i - bomb[1]; j < numbers.Count; j++)
                        {
                            numbers[j] = -1000;
                        }
                    }
                    else if (i < bomb[1] && i + bomb[1] > numbers.Count - 1)
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            numbers[j] = -1000;
                        }
                    }
                    numbers.RemoveAll(item => item == -1000);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
