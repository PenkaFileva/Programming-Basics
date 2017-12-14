using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.ToLower () == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (text.ToLower() == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (text.ToLower() == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (text.ToLower() == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = a * h / 2;
                Console.WriteLine(Math.Round(area, 3));
            }


        }
    }
}
