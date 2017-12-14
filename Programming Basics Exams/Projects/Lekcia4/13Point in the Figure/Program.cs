using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool inside =
               ((x > 0 && x < h && y > 0 && y < h) ||
               (x >= h && x <= h * 2 && y > 0 && y < h) ||
               (x > h * 2 && x < h * 3 && y > 0 && y < h) ||
               (x > h && x < h * 2 && y > h && y < h * 4) ||
               (y==h && x>h && x<h*2));
            bool border =
             ((x == 0 && y >= 0 && y <= h) ||
              (x == h * 3 && y >= 0 && y <= h) ||
               (y == 0 && x >= 0 && x <= h * 3) ||
               (y == h && x >= 0 && x <= h) ||
               (y == h && x >= h * 2 && x <= h * 3) ||
               (x == h && y >= h && y <= h * 4) ||
               (x == h * 2 && y >= h && y <= h * 4) ||
               (y == h * 4 && x >= h && x <= h * 2));
            bool outside =
             ((x > h * 3 && y >= 0 && y <= h) ||
             ( x < h && y > h && y <= h * 4) ||
             (x > h * 2 && y > h && y <= h * 4) ||
             (x >= 0 && y > h * 4) ||
             (x < 0 && y >= 0 ) ||
             (y < 0 && x >= 0 ) ||
             (x < 0 && y < 0));
            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (outside)
            {
                Console.WriteLine("outside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }

        }
    }
}
