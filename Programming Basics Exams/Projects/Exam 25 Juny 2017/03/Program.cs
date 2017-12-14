using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string frute = Console.ReadLine().ToLower();
            string kocteil = Console.ReadLine().ToLower();
            var numDrink = int.Parse(Console.ReadLine());
            var price = 0.0;
            if (kocteil == "small")
            {
                switch(frute)
                {
                    case "watermelon":price = 56.0 * 2;break;
                    case "mango": price = 36.66 * 2; break;
                    case "pineapple": price = 42.10 * 2; break;
                    case "raspberry": price = 20.0 * 2; break;

                }
            }
            else if (kocteil == "big")
            {
                switch (frute)
                {
                    case "watermelon": price = 28.70 * 5; break;
                    case "mango": price = 19.60 * 5; break;
                    case "pineapple": price = 24.80 * 5; break;
                    case "raspberry": price = 15.20 * 5; break;

                }
            }
            var sum = numDrink * price;
            if (sum >1000)
            {
                sum = 0.50 * sum;
            
            }
            else if (sum>=400 && sum <=1000)
            {
                sum = sum - (sum * 0.15);
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
