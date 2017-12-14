using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());  //daljina
            var b = double.Parse(Console.ReadLine());  //visochina
            var a1 = a / 2;
            var door = (a/5)*(a/5);
            var frontRearWall = (a1 *a1)*2+((a1*(b- a1))/2)*2;
            var sideWalls = a * (a / 2) * 2;
            var areaWalls = frontRearWall + sideWalls - door;
            var roof = a * (a / 2) * 2;
            var greenPaint = areaWalls / 3.0;
            var redPaint = roof / 5.0;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
