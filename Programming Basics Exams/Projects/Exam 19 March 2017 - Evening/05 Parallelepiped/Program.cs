using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = 3 * n + 1;
            var h = 4 * n + 4;

            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', w - n));
            for (int i = 0; i < (n * 2) + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', n - 2), new string('.', (n * 2) - i));
            }
            for (int i = 0; i < (n * 2) + 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', (n * 2) - i), new string('~', n - 2));
            }
            Console.WriteLine("{0}+{1}+", new string('.', w - n), new string('~', n - 2));
        }
    }
}
