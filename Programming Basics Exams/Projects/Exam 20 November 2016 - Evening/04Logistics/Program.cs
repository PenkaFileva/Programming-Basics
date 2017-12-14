using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numLoad = double.Parse(Console.ReadLine());
            var tonMinibus = 0.0;
            var tonTruck = 0.0;
            var tonTrain = 0.0;

            for (int i = 1; i <= numLoad; i++)
            {
                var tonnageLoad = double.Parse(Console.ReadLine());
                if (tonnageLoad <= 3)
                {
                    tonMinibus += tonnageLoad;
                }
                else if (tonnageLoad <= 11)
                {
                    tonTruck += tonnageLoad;
                }
                else if (tonnageLoad >= 12)
                {
                    tonTrain += tonnageLoad;
                }
            }
            var sumPrice = tonMinibus * 200.0 + tonTruck * 175.0 + tonTrain * 120.0;
            var sumTonnage = tonMinibus + tonTruck + tonTrain;
            var priseMiddle = sumPrice / sumTonnage;
            var persentMinibus = tonMinibus / sumTonnage * 100;
            var persentTruck = tonTruck / sumTonnage * 100;
            var persentTrain = tonTrain / sumTonnage * 100;

            Console.WriteLine($"{priseMiddle:f2}");
            Console.WriteLine($"{persentMinibus:f2}%");
            Console.WriteLine($"{persentTruck:f2}%");
            Console.WriteLine($"{persentTrain:f2}%");
        }
    }
}
