using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}/|\\{0}", new string('.', ((4 * n + 1)-3)/2));  // red 4*n+1 kolona 2*n+5
            Console.WriteLine("{0}\\|/{0}", new string('.', ((4 * n + 1) - 3) / 2));
            int startEndDots = (4 * n + 1 - 3) / 2;
            
            for (int row = 0; row < 2*n; row++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', startEndDots-row), 
                    new string('-', row));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write("*");
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(".*");                
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
