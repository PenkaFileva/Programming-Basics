using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var kgGrapes = double.Parse(Console.ReadLine()); //kg ot 1 kv.m. plosht
            var brack = double.Parse(Console.ReadLine());

            var sumGrapes = (area * kgGrapes) - brack;
            var zaRakia = sumGrapes * 0.45;
            var zaSale = sumGrapes * 0.55;
            var litarRakia = zaRakia / 7.50;
            var incomeRakia = litarRakia * 9.80;
            var incomeGrapes = zaSale * 1.50;

            Console.WriteLine($"{incomeRakia:f2}");
            Console.WriteLine($"{incomeGrapes:f2}");
        }
    }
}
