using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());  //shirina
            var lengthFloor = double.Parse(Console.ReadLine());  //daljina
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var sumMaster = double.Parse(Console.ReadLine());

            var areaFloor = widthFloor * lengthFloor;
            var areaTriangle = (sideTriangle*heightTriangle)/ 2;
            var numTile = Math.Ceiling(areaFloor / areaTriangle) + 5;
            var totalMoney = (numTile * priceTile) + sumMaster;
            if (totalMoney<=sumMoney)
            {
                Console.WriteLine($"{(sumMoney-totalMoney):f2} lv left.");
            }
            else if (totalMoney > sumMoney)
            {
                Console.WriteLine($"You'll need {(totalMoney-sumMoney):f2} lv more.");
            }
        }
    }
}
