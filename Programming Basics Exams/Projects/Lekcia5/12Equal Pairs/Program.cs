using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
           
            var lastValue = 0;
            var maxDiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var value = firstNum + secondNum;
                if (i>0)
                {
                    var difference = Math.Abs(value - lastValue);
                    if (difference > maxDiff)
                    {
                        maxDiff = difference;
                    }
                }
                lastValue = value;

            }
            if (maxDiff == 0 || n==1 )
            {
                Console.WriteLine("Yes, value = {0}", lastValue);
            }
            else
            {
                Console.WriteLine("No, maxDiff = {0}", maxDiff);
            }
        }
    }
}
