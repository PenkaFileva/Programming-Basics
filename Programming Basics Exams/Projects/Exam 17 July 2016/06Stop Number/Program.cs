using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            for (int i = m; i >= n ; i--)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    if (i == s)
                        break;
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
