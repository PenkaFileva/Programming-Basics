using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());
            var totalSum = 0;
            var moves = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >=1; j--)
                {
                    var sum = i * 2 + j * 3;
                    moves ++;
                    totalSum += sum;
                    if (totalSum >= controlNum)
                        break;
                }
                if (totalSum >= controlNum)
                    break;
            }
            if (totalSum >= controlNum)
            {
                Console.WriteLine($"{moves} moves");
                Console.WriteLine($"Score: {totalSum} >= {controlNum}");
            }
            else
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}
