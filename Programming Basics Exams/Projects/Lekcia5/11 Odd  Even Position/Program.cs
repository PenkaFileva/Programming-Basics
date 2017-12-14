using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0.0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var element = double.Parse(Console.ReadLine());
             if (i %2 == 0)
                {
                    if (element>evenMax)
                    {
                        evenMax = element;  
                    }
                    if ( element < evenMin )
                    {
                        evenMin = element;
                    }
                    evenSum += element;

                }
             else
                {
                    if (element > oddMax)
                    {
                        oddMax = element;
                    }
                    if( element < oddMin)
                    {
                        oddMin = element;
                    }
                    oddSum += element;
                }
            }
            if (n==1)
            {
                Console.WriteLine($"OddSum = {oddSum},OddMin= {oddMin},OddMax= {oddMax},EvenSum= {0},EvenMin= No,EvenMax= No");
            }
            else if (n == 0)
            {
                Console.WriteLine($"OddSum = {0},OddMin= No,OddMax= No,EvenSum= {0},EvenMin= No,EvenMax= No");
            }
            else
            {
                Console.WriteLine($"OddSum = {oddSum},OddMin= {oddMin},OddMax= {oddMax},EvenSum= {evenSum},EvenMin= {evenMin},EvenMax= {evenMax}");
            }

        }
    }
}
