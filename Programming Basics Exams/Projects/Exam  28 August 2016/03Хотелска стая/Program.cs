using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            var num = double.Parse(Console.ReadLine());//noshtuvki
            var studio = 0.0;
            var apartmen = 0.0;
            var priceStudio = 0.0;
            var priceApartamen = 0.0;

            if (month == "may" || month == "october")
            {
                studio = 50.00;
                apartmen = 65.00;
                priceStudio = num * studio;
                priceApartamen = num * apartmen;
                
                if (num > 14)
                {
                    priceStudio = priceStudio - (0.30 * priceStudio);
                    priceApartamen = priceApartamen - (0.10 * priceApartamen);
                }
                else if (num > 7)
                {
                    priceStudio = priceStudio - (0.05 * priceStudio);
                }
            }
            else if (month == "june" || month == "september")
            {
                studio = 75.20;
                apartmen = 68.70;
                priceStudio = num * studio;
                priceApartamen = num * apartmen;

                if (num > 14)
                {
                    priceStudio = priceStudio - (0.20 * priceStudio);
                    priceApartamen = priceApartamen - (0.10 * priceApartamen);
                }
            }
            else if (month == "july" || month == "august")
            {
                studio = 76.00;
                apartmen = 77.00;
                priceStudio = num * studio;
                priceApartamen = num * apartmen;

                if (num > 14)
                {
                    priceApartamen = priceApartamen - (0.10 * priceApartamen);
                }
            }
            Console.WriteLine($"Apartment: {priceApartamen:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
