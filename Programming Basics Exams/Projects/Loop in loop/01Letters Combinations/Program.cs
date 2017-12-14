using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            int count = 0;

            for (char sym1 = first; sym1 <= last; sym1++)
            {
                if(sym1 != skip)
                {
                    for (char sym2 = first; sym2 <= last; sym2++)
                    {
                        if(sym2 != skip)
                        {
                            for (char sym3 = first; sym3 <= last; sym3++)
                            {
                                if(sym3 != skip)
                                {
                                    count++;
                                    string symbol = sym1.ToString() + sym2.ToString() + sym3.ToString();
                                    Console.Write($"{symbol} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
