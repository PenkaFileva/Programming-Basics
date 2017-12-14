using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            for (var i = 1; i <= n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            var rightSum = 0;
            for (int i = n+1; i <=2*n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum- rightSum));
            }
        }
    }
}
