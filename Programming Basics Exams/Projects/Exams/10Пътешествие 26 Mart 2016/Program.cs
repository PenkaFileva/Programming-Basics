using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Пътешествие_26_Mart_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            var sum = 0.0;
            if ( budjet <= 100)
            {
                if (season == "summer")
                {
                    sum = 0.30 * budjet;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", sum);
                }
                else if ( season == "winter")
                {
                    sum = 0.70 * budjet;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
            }
            else if ( budjet <= 1000)
            {
                if (season == "summer")
                {
                    sum = 0.40 * budjet;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", sum);
                }
                else if (season == "winter")
                {
                    sum = 0.80 * budjet;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
            }
            else if ( budjet > 1000)
            {
                if (season == "summer" || season == "winter")
                {
                    sum = 0.90 * budjet;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
            }
        }
    }
}
