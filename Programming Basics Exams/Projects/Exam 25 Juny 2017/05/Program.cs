using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = (4 * n) + 1;
           // var h = (2 * n) + 1;
            var grid = (w-3)/ 2;
            var space = 1;
            Console.WriteLine(new string('#', w));
            for (int i = 1; i <= n; i++)
            {                
                if (i == (n/2)+1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', (n / 2) + 1), new string('#', grid), new string(' ', (space - 3) / 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', grid), new string(' ', space));
                } 
                grid -= 2;
                space += 2;
            }
            space -= 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n+1+i), new string('#',space ));
                space -= 2;
            }
        }
    }
}
