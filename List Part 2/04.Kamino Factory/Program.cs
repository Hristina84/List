using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string command = string.Empty;

            var bestDna = new int[n];
            int counter = 1;
            int bestCounter = 0;
            int currentIndex = 0;
            int bestSequenceIndex = int.MaxValue;
            int sum = 0;
            int bestSequenceSum = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = command.Split('!').Select(x => int.Parse(x)).ToArray();
                sum = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    sum += dna[i];

                    if (dna[i] == 1 && dna[i] == dna[i + 1])
                    {
                        counter++;                        
                        currentIndex = i;

                        if (counter > bestCounter)
                        {                            
                            bestCounter = counter;                           
                            bestDna = dna;
                            if (currentIndex <= bestSequenceIndex)
                            {
                                bestSequenceIndex = i;
                            }
                        }
                        else if (counter == bestCounter && i < bestSequenceIndex)
                        {
                            bestCounter = counter;
                            bestDna = dna;
                        }
                        else if (counter == bestCounter && i == bestSequenceIndex && dna.Sum() > bestDna.Sum())
                        {
                                bestCounter = counter;
                                bestDna = dna;                 
                        }
                    }
                    else
                    {
                        counter = 1;
                        currentIndex = i;
                    }

                }

            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
