using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = 5 * n;
            var h = (3 * n) + 2;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', w -(2*n)), new string('.', n));
            var p = w - (2 * n);
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n-i), new string('.', p), new string('.', n-i));
                p += 2;
            }            
            Console.WriteLine(new string('*', w));

            for (int i = 1; i <= h - (n+2); i++)
            {
                p -= 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', p), new string('.', i));
               
            }          
            Console.WriteLine("{0}*{1}*{0}", new string('.', (w - p)/2), new string('*', p-2));
        }
    }
}
