using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                string name = input[0];
                bool isExistInList = CheckInGuestList(guestList, name);

                if (isExistInList == false)
                {
                    if (input.Count == 3)
                    {
                        guestList.Add(name);
                    }
                    else if (input.Count == 4)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (input.Count == 3)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else if (input.Count == 4)
                    {
                        guestList.Remove(name);
                    }
                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }            
        }

        static bool CheckInGuestList(List<string> guestList, string name)
        {
            for (int i = 0; i < guestList.Count; i++)
            {
                if (name == guestList[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
