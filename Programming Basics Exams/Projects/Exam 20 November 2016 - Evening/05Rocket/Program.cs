using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = 3 * n;
            Console.WriteLine("{0}/\\{0}", new string('.',(w-2)/2));
            var m = 2;
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', (w - 2) / 2 - i), new string(' ', m));
                m += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('*', w - n));
            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', w - n -2));
            }
            var stars = w - (n + 2);
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n/2 - i), new string('*', stars));
                stars += 2;
            }
        }
    }
}
