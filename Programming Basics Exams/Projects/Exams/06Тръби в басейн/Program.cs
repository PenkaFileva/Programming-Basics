using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var v =  int.Parse(Console.ReadLine());
            var pipeOne = int.Parse(Console.ReadLine());
            var pipeTwo = int.Parse(Console.ReadLine());
            var h =  double.Parse(Console.ReadLine());

            var vPipeOne = pipeOne * h;
            var vPipeTwo = pipeTwo * h;
            var totalWaterPipe = vPipeOne + vPipeTwo;

            if(totalWaterPipe <= v)
            {
                var fullPercent =totalWaterPipe / v * 100;
                var p1Percent = vPipeOne / totalWaterPipe * 100;
                var p2Percent = vPipeTwo / totalWaterPipe * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(fullPercent), Math.Truncate(p1Percent), Math.Truncate(p2Percent));
            }
            else if (totalWaterPipe > v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", h, (totalWaterPipe - v));
            }
            
        }
    }
}
