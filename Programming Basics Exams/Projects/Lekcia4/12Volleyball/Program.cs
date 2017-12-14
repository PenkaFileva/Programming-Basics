using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var weekendYear = 48;
            var weekendInSofia = weekendYear - h;
            var saturdayGameInSofia = 3.0 / 4 * weekendInSofia;
            var holidaesInSofia = 2.0 / 3 * p;
            var totalGameYear = 0.0;
            if (year == "normal")
            {
                totalGameYear = h + saturdayGameInSofia + holidaesInSofia;
            }
            else if ( year == "leap")
            {
                totalGameYear = (0.15*(h + saturdayGameInSofia + holidaesInSofia))+ (h + saturdayGameInSofia + holidaesInSofia);
            }
            Console.WriteLine(Math.Truncate(totalGameYear));

        }
    }
}
