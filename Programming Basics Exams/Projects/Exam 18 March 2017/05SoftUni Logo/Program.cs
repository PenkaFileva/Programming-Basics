using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = 4 * n - 2;
            var w = 12 * n - 5;
            var grid = 1;
            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (w-grid)/2), new string('#', grid));
                grid += 6;
            }
            var point = 0;
            grid -= 12;
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2+point), new string('#', grid), new string('.', 3+point));
                grid -= 6;
                point += 3;
            }
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2+point), new string('#', grid), new string('.', 3+point));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', 2 + point), new string('#', grid), new string('.', 3 + point));
        }
    }
}
