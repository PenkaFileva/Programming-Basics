using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Flowers_18_December_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var numChrysanthemum = int.Parse(Console.ReadLine());
            var numRose = int.Parse(Console.ReadLine());
            var numTulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string weekend = Console.ReadLine().ToLower();
            var sumFlower = numChrysanthemum + numRose + numTulip;
            var priceChrysanthemum = 0.0;
            var priceRose = 0.0;
            var priceTulip = 0.0;
            var totalPrice = 0.0;
            if (weekend == "y")
            {
                switch(season)
                {
                    case "spring": priceChrysanthemum = 2.00*0.15+2.00; priceRose = 4.10*0.15+4.10; priceTulip = 2.50*0.15+2.50;break;
                    case "summer": priceChrysanthemum = 2.00*0.15+2.00; priceRose = 4.10*0.15+4.10; priceTulip = 2.50*0.15+2.50; break;
                    case "autumn": priceChrysanthemum = 3.75*0.15+3.75; priceRose = 4.50*0.15+4.50; priceTulip = 4.15*0.15+4.15; break;
                    case "winter": priceChrysanthemum = 3.75*0.15+3.75; priceRose = 4.50*0.15+4.50; priceTulip = 4.15*0.15+4.15; break;
                }
                totalPrice = (numChrysanthemum * priceChrysanthemum) + (numRose * priceRose) + (numTulip * priceTulip);
            }
            else if (weekend == "n")
            {
                switch (season)
                {
                    case "spring": priceChrysanthemum = 2.00; priceRose = 4.10; priceTulip = 2.50; break;
                    case "summer": priceChrysanthemum = 2.00; priceRose = 4.10; priceTulip = 2.50; break;
                    case "autumn": priceChrysanthemum = 3.75; priceRose = 4.50; priceTulip = 4.15; break;
                    case "winter": priceChrysanthemum = 3.75; priceRose = 4.50; priceTulip = 4.15; break;
                }
                totalPrice = (numChrysanthemum * priceChrysanthemum) + (numRose * priceRose) + (numTulip * priceTulip);
            }
            
            if (numTulip > 7 && season == "spring")
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
            }
            if (numRose >= 10 && season == "winter")
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }
            if (sumFlower > 20)
            {
                totalPrice = totalPrice - (totalPrice * 0.20);
            }
            Console.WriteLine($"{(totalPrice+2):f2}");
        }
    }
}
