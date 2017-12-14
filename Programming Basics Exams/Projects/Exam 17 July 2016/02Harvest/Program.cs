using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());  //m plosht
            var y = double.Parse(Console.ReadLine());   //kg grozde ot 1 kv.m
            var z = double.Parse(Console.ReadLine());  //jelani L vino
            var n = double.Parse(Console.ReadLine());  //br. rabotnici
            var recolta = x * y;
            var realRekolta = 0.40 * recolta;
            
            var literVino = realRekolta / 2.5;
            var diff = literVino - z;
            if (diff < 0)
            {
                diff = Math.Abs(diff);
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else if(diff > 0)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literVino)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(diff/n)} liters per person.");
            }
            else if (diff == 0)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literVino)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(diff / n)} liters per person.");
            }
        }
    }
}
