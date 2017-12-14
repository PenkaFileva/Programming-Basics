using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adult = double.Parse(Console.ReadLine());
            var student = double.Parse(Console.ReadLine());
            var night = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            var sumTransport = 0.0;
            if (transport == "train")
            {
                if (adult >= 50 || student >= 50)
                {
                     sumTransport = ((adult * 24.99 + student * 14.99) * 2) - (((adult * 24.99 + student * 14.99) * 2)*0.50);
                }
                else if(adult < 50 || student < 50)
                {
                     sumTransport = (adult * 24.99 + student * 14.99) * 2;                  
                }             
            }
            else if (transport == "bus")
            {
                sumTransport = (adult * 32.50 + student * 28.50) * 2;
            }
            else if (transport == "boat")
            {
                sumTransport = (adult * 42.99 + student * 39.99) * 2;
            }
            else if (transport == "airplane")
            {
                sumTransport = (adult * 70.00 + student * 50.00) * 2;
            }
            var sumNight = night * 82.99;
            var commission = (sumTransport + sumNight) * 0.10;
            var totalSum = sumTransport + sumNight + commission;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
