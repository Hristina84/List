using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "end")
            {
                int element = int.Parse(command[1]);                

                if (command[0] == "Delete")
                {                    
                        input.RemoveAll(item => item == element);                                         
                }
                else if (command[0] == "Insert")
                {
                    int position = int.Parse(command[2]);
                    input.Insert(position, element);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
