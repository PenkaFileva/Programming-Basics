using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double metric = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double midMeter = 0;
            double finalMetric = 0;

            if (from == "mm")midMeter = metric / 1000; 
            else if (from == "cm")midMeter = metric / 100; 
            else if (from == "mi") midMeter = metric / 0.000621371192;
            else if (from == "in") midMeter = metric / 39.3700787;
            else if (from == "km") midMeter = metric / 0.001; 
            else if (from == "ft") midMeter = metric / 3.2808399; 
            else if (from == "yd") midMeter = metric / 1.0936133; 
            else if (from == "m") midMeter = metric; 

            if (to == "mm")  finalMetric = midMeter * 1000; 
            else if (to == "cm")  finalMetric = midMeter * 100; 
            else if (to == "mi")  finalMetric = midMeter * 0.000621371192; 
            else if (to == "in")  finalMetric = midMeter * 39.3700787; 
            else if (to == "km")  finalMetric = midMeter * 0.001; 
            else if (to == "ft")  finalMetric = midMeter * 3.2808399; 
            else if (to == "yd")  finalMetric = midMeter * 1.0936133; 
            else if (to == "m") finalMetric = midMeter; 

            Console.WriteLine($"{finalMetric} {to}");
        }
    }
}
