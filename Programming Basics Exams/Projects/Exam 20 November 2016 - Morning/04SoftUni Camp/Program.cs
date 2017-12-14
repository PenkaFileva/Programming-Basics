using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var numCar = 0.0;
            var numMinibus = 0.0;
            var numSmallBus = 0.0;
            var numBigBus = 0.0;
            var numTrain = 0.0;

            for (int i = 0; i < group; i++)
            {
                var people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    numCar += people;
                }
                else if (people <= 12)
                {
                    numMinibus += people;
                }
                else if (people <= 25)
                {
                    numSmallBus += people;
                }
                else if (people <= 40)
                {
                    numBigBus += people;
                }
                else if (people >= 41)
                {
                    numTrain += people;
                }
            }
            var sumPeople = numCar + numMinibus + numSmallBus + numBigBus + numTrain;
            var numCarPercent = (numCar / sumPeople) * 100;
            var numMinibusPercent = (numMinibus / sumPeople) * 100;
            var numSmallBusPercent = (numSmallBus / sumPeople) * 100;
            var numBigBusPercent = (numBigBus / sumPeople) * 100;
            var numTrainPercent = (numTrain / sumPeople) * 100;

            Console.WriteLine($"{numCarPercent:f2}%");
            Console.WriteLine($"{numMinibusPercent:f2}%");
            Console.WriteLine($"{numSmallBusPercent:f2}%");
            Console.WriteLine($"{numBigBusPercent:f2}%");
            Console.WriteLine($"{numTrainPercent:f2}%");
        }
    }
}
