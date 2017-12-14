using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());//5*n koloni
            var w = 5 * n;
            if (n % 2 == 0)
            {
                var h = n * 2;
                var h1 = h - (1 + n + (n / 2));

                Console.WriteLine("{0}**{1}", new string('-', n * 3), new string('-', w - 2 - (n * 3)));
                for (int i = 1; i <= n - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', i), new string('-', w - 2 - (n * 3) - i));
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("{0}{1}*{1}", new string('*', (n * 3) + 1), new string('-', n - 1), new string('-', n - 1));
                }
                var m = n - 1;
                var j = n*3;
                if (h1>0)
                {
                    
                    for (int i = 0; i < h1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{2}", new string('-', (n * 3)-i), new string('-', m), new string('-', (n - 1)-i));
                        m += 2;
                        j -= 1;
                    }
                }
                Console.WriteLine("{0}{1}{2}", new string('-', j), new string('*', m+2), new string('-', w-(j+m+2)));
            }
            else
            {
                var h = (2 * n) - 1;
                var h1 = h - (1 + n + (n / 2));

                Console.WriteLine("{0}**{1}", new string('-', n * 3), new string('-', w - 2 - (n * 3)));
                for (int i = 1; i <= n - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', i), new string('-', w - 2 - (n * 3) - i));
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("{0}{1}*{1}", new string('*', (n * 3) + 1), new string('-', n - 1), new string('-', n - 1));
                }
                var m = n - 1;
                var j = n * 3;
                if (h1>0)
                {
                    for (int i = 0; i < h1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{2}", new string('-', (n * 3) - i), new string('-', m), new string('-', (n - 1) - i));
                        m += 2;
                        j -= 1;
                    }
                }

                Console.WriteLine("{0}{1}{2}", new string('-', j), new string('*', m+2), new string('-', w - (j + m+2)));

            }
           
        }
    }
}
