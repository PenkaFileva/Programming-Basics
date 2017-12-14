using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());  //visochina
            var y = double.Parse(Console.ReadLine());  //daljina
            var h = double.Parse(Console.ReadLine());  //visochina na triagalnika

            var windows = 1.5 * 1.5 * 2;
            var door = 1.2 * 2.0;
            var frontRearWall = x * x * 2;
            var sideWalls = x * y * 2;
            var areaWalls = frontRearWall + sideWalls - windows - door;
            var roof = ((x * h) / 2) * 2 + (x * y) * 2;
            var greenPaint = areaWalls / 3.40;
            var redPaint = roof / 4.30;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
