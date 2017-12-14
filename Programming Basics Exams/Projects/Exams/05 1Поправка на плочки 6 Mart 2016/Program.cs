using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1Поправка_на_плочки_6_Mart_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());  //ploshtatka kvadrat
            var w = double.Parse(Console.ReadLine());  //shirina na plochkata
            var l = double.Parse(Console.ReadLine());  //daljina na plochkata
            var m = double.Parse(Console.ReadLine());  //shirina na peikata
            var o = double.Parse(Console.ReadLine());  //daljina na peikata

            var areaLanding = n * n;
            var areaBench = m * o;
            var areaTile = w * l;
            var areaWorksite = areaLanding - areaBench;
            var numberTile = areaWorksite / areaTile;
            var time = numberTile * 0.2;
            Console.WriteLine("{0:f2}", numberTile);
            Console.WriteLine("{0:f2}", time);
        }
    }
}
