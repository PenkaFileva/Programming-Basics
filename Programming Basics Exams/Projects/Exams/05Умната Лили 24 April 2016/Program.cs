using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Умната_Лили_24_April_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double evenSumBirthDay = 0.0;
            int oddNumToys = 0;

            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    if(i == 2)
                    {
                        evenSumBirthDay += 10;
                        evenSumBirthDay -= 1;
                    }
                    else if(i >2)
                    {
                        evenSumBirthDay = evenSumBirthDay + 10 * i / 2;
                        evenSumBirthDay -= 1;
                    }
                }
                else
                {
                    oddNumToys += 1;
                }
            }
            double sumToys = oddNumToys * priceToys;
            double sumTotal = sumToys + evenSumBirthDay;
            double diff =(sumTotal - priceLaundry);

            if (diff >= 0)
            {
                Console.WriteLine("Yes! {0:f2}", (diff));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", (Math.Abs(diff)));
            }
        }
    }
}
