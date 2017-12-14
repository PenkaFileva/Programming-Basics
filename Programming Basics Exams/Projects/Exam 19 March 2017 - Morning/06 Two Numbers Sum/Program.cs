using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            var combination = 0;
            var sum = 0;
            for (int i = n; i >= m; i--)
            {
                for (int j = n; j >= m; j--)
                {
                    var sum1 = i + j;
                    sum = sum1;
                    combination += 1;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNum})");
                        break;
                    }  
                }
                if (sum == magicNum)
                {
                    break;
                }
            }
            if (sum!=magicNum)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");

            }
        }
    }
}
