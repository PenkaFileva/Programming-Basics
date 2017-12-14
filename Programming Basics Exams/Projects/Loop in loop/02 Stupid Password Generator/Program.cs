using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int num1 = 1; num1 <= n-1; num1++)
            {
                for (int num2 = 1; num2 <= n-1; num2++)
                {
                    for (char num3 = 'a'; num3 < 'a'+l; num3++)
                    {
                        for (char num4 = 'a'; num4 < 'a'+l; num4++)
                        {
                            for (int num5 = 2; num5 <= n; num5++)
                            {
                                if(num5>num1 && num5>num2)
                                {
                                    string symbol = num1.ToString() + num2 + num3.ToString() + num4.ToString() + num5;
                                    Console.Write($"{symbol} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
