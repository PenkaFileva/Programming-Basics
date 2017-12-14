using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var hw = 2 * n + 1;
            Console.WriteLine(new string ('*', 2*n+1));
            Console.WriteLine(".*{0}*.", new string(' ', hw - 4));
            var et = hw - 6;
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i+1), new string('@', et));
                et -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n-1-i), new string(' ', i));
            }
            Console.WriteLine(".*{0}*.", new string('@', hw - 4));
            Console.WriteLine(new string('*', 2 * n + 1));

        }
    }
}
