using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var numJuniors = double.Parse(Console.ReadLine());
            var numSeniors = double.Parse(Console.ReadLine());
            string route = Console.ReadLine().ToLower();
            var sum = numJuniors + numSeniors;
            var taxa = 0.0;
            if (route == "trail")
            {
                 taxa = numJuniors*5.50 + numSeniors*7.00;
            }
            else if (route == "cross-country")
            {
                 taxa = numJuniors*8.00 + numSeniors*9.50;
                if (sum >= 50)
                {
                    taxa = taxa - 0.25 * taxa;
                }
            }
            else if (route == "downhill")
            {
                 taxa = numJuniors*12.25 + numSeniors*13.75;
            }
            else if (route == "road")
            {
                 taxa = numJuniors*20.00 + numSeniors*21.50;
            }
            var donatedSum = taxa - 0.05 * taxa;
            Console.WriteLine($"{donatedSum:f2}");
        }
    }
}
