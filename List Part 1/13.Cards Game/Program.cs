using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondPlayerCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            int n = Math.Min(firstPlayerCards.Count, secondPlayerCards.Count);

            while (n > 0)
            {
                for (int i = 0; i < Math.Min(firstPlayerCards.Count, secondPlayerCards.Count); i++)
                {
                    if (firstPlayerCards[i] > secondPlayerCards[i])
                    {
                        firstPlayerCards.Add(firstPlayerCards[i]);
                        firstPlayerCards.Remove(firstPlayerCards[i]);
                        firstPlayerCards.Add(secondPlayerCards[i]);
                        secondPlayerCards.Remove(secondPlayerCards[i]);
                    }
                    else if (firstPlayerCards[i] == secondPlayerCards[i])
                    {
                        firstPlayerCards.Remove(firstPlayerCards[i]);
                        secondPlayerCards.Remove(secondPlayerCards[i]);
                    }
                    else
                    {
                        secondPlayerCards.Add(secondPlayerCards[i]);
                        secondPlayerCards.Remove(secondPlayerCards[i]);
                        secondPlayerCards.Add(firstPlayerCards[i]);
                        firstPlayerCards.Remove(firstPlayerCards[i]);
                    }
                    i--;
                }
                n = Math.Min(firstPlayerCards.Count, secondPlayerCards.Count);
            }
            if (firstPlayerCards.Count == 0)
            {
                foreach (var number in secondPlayerCards)
                {
                    sum += number;                    
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                foreach (var number in firstPlayerCards)
                {
                    sum += number;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}


