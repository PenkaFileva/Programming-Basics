using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numPeople = int.Parse(Console.ReadLine());

            var result = 0.0;
            var from0To9 = 0.0;
            var from10To19 = 0.0;
            var from20To29 = 0.0;
            var from30To39 = 0.0;
            var from40To50 = 0.0;
            var invalidNum = 0.0;

            for (int i = 1; i <= numPeople; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9)
                {
                    from0To9 += 1;
                    result += 0.20 * num;
                }
                else if (num < 0 || num > 50)
                {
                    invalidNum += 1;
                    result = result / 2;
                }
                else if (num <= 19)
                {
                    from10To19 += 1;
                    result += 0.30 * num;
                }
                else if (num <= 29)
                {
                    from20To29 += 1;
                    result += 0.40 * num;
                }
                else if (num <= 39)
                {
                    from30To39 += 1;
                    result += 50;
                }
                else if (num <= 50)
                {
                    from40To50 += 1;
                    result += 100;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(from0To9/numPeople*100):f2}%");
            Console.WriteLine($"From 10 to 19: {(from10To19/numPeople*100):f2}%");
            Console.WriteLine($"From 20 to 29: {(from20To29/numPeople*100):f2}%");
            Console.WriteLine($"From 30 to 39: {(from30To39 / numPeople * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(from40To50 / numPeople * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(invalidNum / numPeople*100):f2}%");
        }
    }
}
