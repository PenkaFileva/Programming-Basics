using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var text = Console.ReadLine().ToLower();

            if (km < 20)
            {
                if (text == "day")
                {
                    var price1 = 0.70 + km * 0.79;
                    Console.WriteLine(price1);
                }
                else if (text == "night")
                {
                    var price2 = 0.70 + km * 0.90;
                    Console.WriteLine(price2);
                }
            }
            else if (km < 100)
            {
                if (text == "day" || text == "night")
                {
                    var price3 = km * 0.09;
                    Console.WriteLine(price3);
                }
            }
            else if (km >= 100)
            {
                if (text == "day" || text == "night")
                {
                    var price4 = km * 0.06;
                    Console.WriteLine(price4);
                }
            }
        }
    }
}
