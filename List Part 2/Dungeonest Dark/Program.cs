using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            var dungeonsRooms = Console.ReadLine().Split('|').ToArray();

            int health = 100;
            int coins = 0;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                var command = dungeonsRooms[i].Split().ToArray();

                switch (command[0])
                {
                    case "potion":

                        int healthEarn = int.Parse(command[1]);

                        if (health + healthEarn < 100)
                        {
                            health += healthEarn;
                            Console.WriteLine($"You healed for {healthEarn} hp.");
                        }
                        else if((health + healthEarn > 100))
                        {                            
                            Console.WriteLine($"You healed for {(100 - health)} hp.");                           
                            health = 100;
                        }
                        else if ((health == 100))
                        {
                            health = 100;
                            Console.WriteLine($"You healed for {0} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":

                        int coinsEarn = int.Parse(command[1]);

                        Console.WriteLine($"You found {coinsEarn} coins.");
                        coins += coinsEarn;

                        break;
                    default:
                        int healthRemoved = int.Parse(command[1]);

                        if (healthRemoved >= health)
                        {
                            Console.WriteLine($"You died! Killed by {command[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        health -= healthRemoved;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command[0]}.");                            
                        }
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
