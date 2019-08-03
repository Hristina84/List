using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {                
                string[] inputNums = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < inputNums.Length; j++)
                {                  
                    result.Add(int.Parse(inputNums[j]));
                }            
            }
            Console.Write(string.Join(" ", result));
        }
    }
}
