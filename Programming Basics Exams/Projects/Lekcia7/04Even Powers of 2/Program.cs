using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i+=2)
            {
                // num = (int)Math.Pow(2, i);
                Console.WriteLine(num);
                num = num * 2 * 2;

            }
        }
    }
}
