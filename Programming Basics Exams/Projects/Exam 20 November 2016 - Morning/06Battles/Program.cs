using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var buttle = int.Parse(Console.ReadLine());
            var numButtle = 0;
            for (int i = 1; i <= n1 ; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    if (numButtle == buttle)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                    numButtle += 1;                   
                }
            }
            Console.WriteLine();

            //int p1 = int.Parse(Console.ReadLine());
            //int p2 = int.Parse(Console.ReadLine());
            //int maxBattles = int.Parse(Console.ReadLine());
            //var battles = 0;
            //for (int i1 = 1; i1 <= p1; i1++)
            //{
            //
            //    for (int i2 = 1; i2 <= p2; i2++)
            //    {
            //        if (battles == maxBattles)
            //        {
            //            break;
            //        }
            //        Console.Write("({0} <-> {1}) ", i1, i2);
            //        battles++;
            //    }
            //}
        }
    }
}
