using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var totalSec = sec1 + sec2 + sec3;
            var minutes = totalSec / 60;
            var seconds = totalSec % 60;
            Console.WriteLine($"{ minutes}:{ seconds:00}");

        }
    }
}
