using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagonsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            var command = Console.ReadLine().Split(' ').ToList();
            int passengers = 0;           

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagonsList.Add(int.Parse(command[1]));
                }
                else
                {
                    passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagonsList.Count; i++)
                    {
                        if (wagonsList[i] + passengers <= wagonCapacity)
                        {
                            wagonsList[i] += passengers;                           
                            break;
                        }
                    }                    
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(String.Join(" ", wagonsList));
        }
    }
}
