using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());

            if (num1 == num2)
                if (num2 == num3)
                {
                    Console.WriteLine("yes");
                }
                
                else if (num2 != num3)
                {
                    Console.WriteLine("no");
                }
            if (num1 != num2)
            {
                Console.WriteLine("no");
            }
        }
    }
}
