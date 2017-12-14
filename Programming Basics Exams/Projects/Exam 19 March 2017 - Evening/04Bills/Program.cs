using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = int.Parse(Console.ReadLine());
            var sumElectricity = 0.0;
            var sumDrRazhody = 0.0;
            var water = 20.0;
            var intrenet = 15.0;

            for (int i = 1; i <= month; i++)
            {
                var electricity = double.Parse(Console.ReadLine());
                sumElectricity += electricity;
                var razhody = electricity + water + intrenet;
                var drRazhody = razhody + razhody *0.20;
                sumDrRazhody += drRazhody;

            }
            var sumWater = water * month;
            var sumIntrenet = intrenet * month;
            var averageSumMonth = (sumElectricity + sumDrRazhody + sumWater + +sumIntrenet) / month;

            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {sumWater:f2} lv");
            Console.WriteLine($"Internet: {sumIntrenet:f2} lv");
            Console.WriteLine($"Other: {sumDrRazhody:f2} lv");
            Console.WriteLine($"Average: {averageSumMonth:f2} lv");
        }
    }
}
