using System;
using System.Linq;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = string.Empty;

            var bestDna = new int[n];
            int counter = 1;
            int bestCounter = 0;
            int currentIndex = 0;
            int bestSequenceIndex = int.MaxValue;
            int dnaNumber = 0;
            int bestDnaNumber = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = command.Split('!').Select(s => s.Trim()).Select(x => int.Parse(x)).ToArray();
                dnaNumber++;

                for (int i = 0; i < n - 1; i++)
                {
                    if (dna[i] == 1)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (dna[i] == dna[j])
                            {
                                counter++;
                                currentIndex = i;

                                if (counter > bestCounter)
                                {
                                    bestCounter = counter;
                                    bestDna = dna;
                                    bestSequenceIndex = i;
                                    bestDnaNumber = dnaNumber;
                                }
                                else if (counter == bestCounter)
                                {
                                    if (currentIndex < bestSequenceIndex)
                                    {
                                        bestCounter = counter;
                                        bestDna = dna;
                                        bestSequenceIndex = i;
                                        bestDnaNumber = dnaNumber;
                                    }
                                    else if (currentIndex == bestSequenceIndex && dna.Sum() > bestDna.Sum())
                                    {
                                        bestCounter = counter;
                                        bestDna = dna;
                                        bestSequenceIndex = i;
                                        bestDnaNumber = dnaNumber;
                                    }
                                }
                            }
                            else
                            {
                                counter = 1;
                                currentIndex = 0;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestDnaNumber} with sum: {bestDna.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}

