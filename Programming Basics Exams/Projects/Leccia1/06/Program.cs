using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i ++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int r = 0; r < n-2; r++)
            {
                Console.Write("*");
                {
                    for (int i = 0; i < n-2; i++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
            for (var i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}