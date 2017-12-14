using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // int gcd = 0;
            // for (int i = 1; i <= b; i++)
            // {
            //     if (a % i == 0 && b % i == 0)
            //     {
            //         gcd = i;
            //     }
            // }
            // Console.WriteLine(gcd);

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine(a);
        }
    }
}
