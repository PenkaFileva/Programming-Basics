using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = (n + 1) * 2 + (2 * n + 1);

            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', 2*n+1));
            var space = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n-i), new string('_', (2 * n + 1-2) +space));
                space += 2;                                 
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (w-9)/2));
            Console.WriteLine("\\\\{0}//", new string ('_', w-4));
            var space1 = w - 6;
            for (int i = n-1; i >= 1; i--)
            {               
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', n - i), new string('_', space1));
                space1 -= 2;
            }           
        }
    }
}
