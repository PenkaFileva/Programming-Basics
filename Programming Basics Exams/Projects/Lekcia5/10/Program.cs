using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
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
                var curreantNum = int.Parse(Console.ReadLine());
                sum += curreantNum;
                if ( curreantNum > greatestNum)
                {
                    greatestNum = curreantNum;
                }
            }
            sum -= greatestNum;
            if ( sum == greatestNum)
            {
                Console.WriteLine("Yes sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(sum - greatestNum));
            }
        }
    }
}
