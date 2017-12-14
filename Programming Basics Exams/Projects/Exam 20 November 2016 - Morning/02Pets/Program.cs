using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numDay = double.Parse(Console.ReadLine());
            var kgFood = double.Parse(Console.ReadLine());
            var kgFoodDayDog = double.Parse(Console.ReadLine());
            var kgFoodDayKat = double.Parse(Console.ReadLine());
            var grFoodDayTurtle = double.Parse(Console.ReadLine());

            var sumFoodDog = kgFoodDayDog * numDay;
            var sumFoodKat = kgFoodDayKat * numDay;
            var sumFoodTurtle = (grFoodDayTurtle * numDay)/1000;
            var sumFood = sumFoodDog + sumFoodKat + sumFoodTurtle;
            if (kgFood >= sumFood)                                  // = to e mnogo vajno
            {
                Console.WriteLine($"{Math.Floor(kgFood - sumFood)} kilos of food left.");
            }
            else if (sumFood > kgFood)
            {
                Console.WriteLine($"{Math.Ceiling(sumFood - kgFood)} more kilos of food are needed.");
            }
        }
    }
}
