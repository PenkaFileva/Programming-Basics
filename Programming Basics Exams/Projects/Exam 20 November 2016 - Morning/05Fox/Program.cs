using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = 2 * n + 3;
            var dash = w - 4;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', dash));
                dash -= 2;
            }
            var stars1 = w - 4 - 2 * (n / 2);
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', stars1));
                stars1 -= 2;
            }       
            var stars = w - 4;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', stars));
                stars -= 2;
            }
        }
    }
}
