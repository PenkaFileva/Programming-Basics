using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var premiere = 12;
            var normal = 7.5;
            var discount = 5;
            var sales = 0.0;
            if (text =="premiere")
            {
                sales = r * c * premiere;
            }
            else if (text == "normal")
            {
                sales = r * c * normal;
            }
            else if (text =="discount")
            {
                sales = r * c * discount;
            }
            Console.WriteLine("{0:f2}" + " leva", sales);

        }
    }
}
