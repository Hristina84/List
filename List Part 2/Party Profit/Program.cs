using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int sum = days * 50;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }      
                
                int moneyForFood = 2 * partySize;
                sum -= moneyForFood;

                if (i % 3 == 0)
                {
                    int moneyForDrink = 3 * partySize;
                    sum -= moneyForDrink;
                }
                if (i % 5 == 0)
                {
                    int gainPerCompanion = 20 * partySize;
                    sum += gainPerCompanion;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    int aditionalSpend = 2 * partySize;
                    sum -= aditionalSpend;
                }               
            }

            Console.WriteLine($"{partySize} companions received {sum / partySize} coins each.");
        }
    }
}
