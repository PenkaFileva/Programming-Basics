using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            var num = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (num >= stop)
                    {
                        break;
                    }
                    Console.Write($"<{i}-{j}>");
                    num += 1;
                }
            }
        }
    }
}
