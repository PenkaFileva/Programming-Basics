using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = string.Empty;
            string location = string.Empty;
            var price = 0.0;
            if (budget<= 1000)
            {
                switch (season)
                {
                    case "summer":location = "Alaska";place = "Camp";price = 0.65 * budget;break;
                    case "winter": location = "Morocco"; place = "Camp"; price = 0.45 * budget; break;
                }
            }
            else if (budget <= 3000)
            {
                switch (season)
                {
                    case "summer": location = "Alaska"; place = "Hut"; price = 0.80 * budget; break;
                    case "winter": location = "Morocco"; place = "Hut"; price = 0.60 * budget; break;
                }
            }
            else if (budget > 3000)
            {
                switch (season)
                {
                    case "summer": location = "Alaska"; place = "Hotel"; price = 0.90 * budget; break;
                    case "winter": location = "Morocco"; place = "Hotel"; price = 0.90 * budget; break;
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
