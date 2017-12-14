using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSreed = double.Parse(Console.ReadLine()); // v km/h
            var firstTime = double.Parse(Console.ReadLine());  //v min
            var secondTime = double.Parse(Console.ReadLine());
            var lastTime = double.Parse(Console.ReadLine());
            var firstHour = firstTime / 60;
            var secondHour = secondTime / 60;
            var lastHour = lastTime / 60;

            var firstkm = firstSreed * firstHour; // km
            var secondSpeed = firstSreed + firstSreed * 0.10;
            var secondkm = secondSpeed * secondHour;
            var lastSpeed = secondSpeed - secondSpeed * 0.05;
            var lastkm = lastSpeed * lastHour;

            var totalkm = firstkm + secondkm + lastkm;
            Console.WriteLine($"{totalkm:f2}");

        }
    }
}
