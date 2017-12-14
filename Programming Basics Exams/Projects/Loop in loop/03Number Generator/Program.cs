using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());
            var specialN = specialNum;
            var mnl = 0;
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                         mnl = (100 * i + 10 * j + k);                        
                         if (mnl % 3 == 0)
                             specialN += 5;
                         else if (mnl % 10 == 5)
                             specialN -= 2;   
                         else if (mnl % 2 == 0)
                             specialN *= 2;
                        if (specialN >= controlNum)
                            break;
                    }
                    if (specialN >= controlNum)
                        break;
                }
                if (specialN >= controlNum)
                    break;
            }            
            if (specialN >= controlNum)
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialN);
            else if (specialN < controlNum)
                Console.WriteLine("No! {0} is the last reached special number.", specialN);
        }
    }
}
