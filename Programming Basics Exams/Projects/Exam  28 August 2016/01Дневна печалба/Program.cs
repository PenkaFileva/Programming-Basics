using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDay = double.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine()); //dolary
            var dolar = double.Parse(Console.ReadLine());
            var profitYear = (workDay * money * 12) + (workDay * money*2.5);
            var taxesYear = profitYear * 0.25;
            var pureProfit = profitYear - taxesYear;
            var profitLeva = pureProfit * dolar;
            var pureProfitDay = profitLeva / 365;
            Console.WriteLine($"{pureProfitDay:f2}");

        }
    }
}
