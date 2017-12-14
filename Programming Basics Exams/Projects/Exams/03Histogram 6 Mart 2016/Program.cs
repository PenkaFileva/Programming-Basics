using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Histogram_6_Mart_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num < 200) p1++;
                else if (num >= 200 && num < 400) p2++;
                else if (num >= 400 && num < 600) p3++;
                else if (num >= 600 && num < 800) p4++;
                else  p5++;
            }
            double p1p = (p1 / n) * 100;
            double p2p = (p2 / n) * 100;
            double p3p = (p3 / n) * 100;
            double p4p = (p4 / n) * 100;
            double p5p = (p5 / n) * 100;

            Console.WriteLine($"{p1p:f2}%");
            Console.WriteLine("{0:f2}%", p2p);
            Console.WriteLine("{0:f2}%", p3p);
            Console.WriteLine("{0:f2}%", p4p);
            Console.WriteLine("{0:f2}%", p5p);
        }
    }
}
