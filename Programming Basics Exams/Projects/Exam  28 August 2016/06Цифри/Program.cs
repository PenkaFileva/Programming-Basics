using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num1 = n/100;
            var num2 = (n / 10) % 10; 
            var num3 = n % 10;

            var row = num1 + num2;
            var col = num1 + num3;
            //Console.WriteLine(row);
            //Console.WriteLine(col);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - num1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - num2;
                    }
                    else 
                    {
                        n = n + num3;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
