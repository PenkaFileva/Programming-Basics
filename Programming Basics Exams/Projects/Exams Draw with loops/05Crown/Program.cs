using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = (2 * n) - 1;
            Console.WriteLine("@{0}@{0}@", new string(' ', (w -3)/2));
            Console.WriteLine("**{0}*{0}**", new string(' ', (w-5)/2));
            var point = 1;
            var space = (w - 9) / 2;
            var h = (n / 2) + 4;
            var point1 = 0;
            for (int i = 1; i <= h-6; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i), new string(' ', space), new string('.', point));
                space -= 2;
                point += 2;
                point1 = i;         
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', point1+1), new string('.', point));

            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', point1+2), new string('*', (point-1)/2));
            Console.WriteLine("{0}",new string('*', w));
            Console.WriteLine("{0}",new string('*', w));
        }
    }
}
