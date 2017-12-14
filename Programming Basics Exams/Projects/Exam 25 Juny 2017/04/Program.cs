using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var part = int.Parse(Console.ReadLine());
            var bonusOnePoint = double.Parse(Console.ReadLine());
            var sumPoint = 0.0;
            for (int i = 1; i <= part; i++)
            {
                var point = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    sumPoint += point * 2;
                }
                else
                {
                    sumPoint += point;
                }
            }
            var award = sumPoint * bonusOnePoint;
            Console.WriteLine($"The project prize was {award:f2} lv.");
        }
    }
}
