using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var greatestNum = 0;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum > greatestNum)
                {
                    sum += greatestNum;
                    greatestNum = currentNum;
                }
                else
                {
                    sum += currentNum;
                }
            }
            if (sum == greatestNum)
            {
                Console.WriteLine($"Yes sum = {sum }");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(sum-greatestNum)}");
            }
        }
    }
}
