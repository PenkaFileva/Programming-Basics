using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var dayFirma = double.Parse(Console.ReadLine());
            var numEmployees = double.Parse(Console.ReadLine());
            var sumHoursFirma = ((dayFirma  - (0.10 * dayFirma)) * 8);
            var sumHouraEmployees = 2 * dayFirma * numEmployees;
            var totalHoursFirma = Math.Floor(sumHoursFirma + sumHouraEmployees);
            if (totalHoursFirma >= hours)
            {
                Console.WriteLine($"Yes!{(totalHoursFirma - hours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{(hours - totalHoursFirma)} hours needed.");
            }
        }   
    }
}
