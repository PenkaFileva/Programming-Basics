using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string speciesClass = string.Empty;
            string car = string.Empty;
            var price = 0.0;
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer": car = "Cabrio"; speciesClass = "Economy class"; price = 0.35 * budget; break;
                    case "winter": car = "Jeep"; speciesClass = "Economy class"; price = 0.65 * budget; break;
                }
            }
            else if (budget <= 500)
            {
                switch (season)
                {
                    case "summer": car = "Cabrio"; speciesClass = "Compact class"; price = 0.45 * budget; break;
                    case "winter": car = "Jeep"; speciesClass = "Compact class"; price = 0.80 * budget; break;
                }
            }
            else if (budget > 500)
            {
                switch (season)
                {
                    case "summer": 
                    case "winter": car = "Jeep"; speciesClass = "Luxury class"; price = 0.90 * budget; break;
                }
            }
            Console.WriteLine($"{speciesClass}");
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}
