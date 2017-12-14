using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                int curNum = n % 10;
                sum += curNum;
                n = n / 10;

            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
