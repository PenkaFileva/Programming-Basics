using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine(min);
        }
    }
}
