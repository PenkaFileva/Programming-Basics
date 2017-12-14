using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var text = Console.ReadLine().ToLower();
            var priceTaxiDay = 0.0;
            var priceTaxiNight = 0.0;
            var priceBus = 0.0;
            if (km < 20)
            {
                if (text == "day")
                {
                    var price1 = 0.70 + km * 0.79;
                    priceTaxiDay = price1;
                }
                else if (text == "night")
                {
                    var price2 = 0.70 + km * 0.90;
                    priceTaxiNight = price2;
                }
            }
            else if (km < 100)
            {
                if (text == "day" || text == "night")
                {
                    var price3 = km * 0.09;
                    priceBus = price3;
                }
            }
            else if (km >= 100)
            {
                if (text == "day" || text == "night")
                {
                    var price3 = km * 0.09;
                    priceBus = price3;
                }
            }
            Console.WriteLine(Math.Min(priceTaxiDay, priceTaxiNight));
        }
    }
}
