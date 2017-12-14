using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitkoin = double.Parse(Console.ReadLine());
            var kitaiskiUan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());
            var convBitkoinLeva = bitkoin * 1168.0;
            var convKitaiskiUanDolar = kitaiskiUan * 0.15;
            var dolarLeva = convKitaiskiUanDolar * 1.76;
            var totalLeva = convBitkoinLeva + dolarLeva;
            var euro = totalLeva / 1.95;
            var totalEuro = euro - (commission / 100) * euro;
            Console.WriteLine($"{totalEuro:f2}");

            //int bitcoins = int.Parse(Console.ReadLine());
            //var yuans = double.Parse(Console.ReadLine());
            //var commision = double.Parse(Console.ReadLine()) / 100.00;
            //
            //var bitcoinsInLeva = bitcoins * 1168.0;
            //var yuansToDollars = yuans * 0.15;
            //var dollarsToLeva = yuansToDollars * 1.76;
            //
            //var levas = bitcoinsInLeva + dollarsToLeva;
            //var euros = levas / 1.95;
            //euros -= commision * euros;
            //Console.WriteLine(euros);
        }
    }
}
