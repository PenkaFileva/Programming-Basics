using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var maney = double.Parse(Console.ReadLine());
            var age = double.Parse(Console.ReadLine());
            var ageIvancho = 18;
            var sum = 0.0;
            for (int i = 1800; i <= age; i++)
            {
                if (i == 1800)
                {
                    var sum1 = maney - 12000;
                    ageIvancho += 1;
                    sum = sum1;
                }
                else if (i % 2 == 0)
                {
                    var sum1 = sum - 12000;
                    ageIvancho += 1;
                    sum = sum1;
                }
                else if( i % 2 != 0)
                {
                    var sum1 = sum - 12000 - ageIvancho * 50;
                    ageIvancho += 1;
                    sum = sum1;
                }
            }
            if (sum < 0)
            {
                Console.WriteLine($"He will need {(Math.Abs(sum)):f2} dollars to survive.");
            }
            else if (sum <= maney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {sum:f2} dollars left.");
            }
            
        }
    }
}
