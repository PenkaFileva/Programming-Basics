using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 0;

            if( n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }
            if (n > 2)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', stars));
                    stars += 2;
                }
                stars -= 2;
                for (int i = (n - 1) / 2 - 1; i >= 1; i--)
                {
                    stars -= 2;
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', stars));
                }
                Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));
            }
            else if ( n == 1 || n == 2)
            {
                Console.WriteLine( new string ('*', stars));
            }
        }
    }
}
