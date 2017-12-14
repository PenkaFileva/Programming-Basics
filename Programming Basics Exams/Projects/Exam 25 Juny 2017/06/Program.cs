using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var sum1 = 0;
            bool x = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        sum = a + b + c;
                        sum1 = a * b * c;
                        if (sum == n && (a < b && b < c))
                        {
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                            x = true;
                        }
                        if (sum1 == n && (a > b && b > c))
                        {
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                            x = true;
                        }
                        //if ((sum == n && (a > b && b > c)) &&
                        //(sum1 == n && (a < b && b < c)) &&
                        //(sum != n && (a < b && b < c)) &&
                        //(sum1 != n && (a > b && b > c)))
                        //{
                        //    Console.WriteLine("No!");    
                        //}
                    }
                }
            }
            if (x == false)
            {
                Console.WriteLine("No!");
            }
        }       
    }      
}
    


