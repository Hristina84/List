using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam.Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApronPrice = double.Parse(Console.ReadLine());

            double a = student + Math.Round((double)student * 0.2);
            int b = singleApronPrice * a;
            double c = singleEggPrice * 10 * student;
            double d = flourPrice * (student - student / 5);

            double price = singleApronPrice * (student + Math.Round((double)student * 0.2)) +
                singleEggPrice * 10 * student + flourPrice * (student - student / 5);

            if (price <= budget)
            {
                Console.WriteLine($"Items purchased for {price:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(price - budget):f2}$ more needed.");
            }
        }
    }
}
