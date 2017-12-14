using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalStadium = double.Parse(Console.ReadLine());
            var fens = double.Parse(Console.ReadLine());
            
            var sumA = 0.0;
            var sumB = 0.0;
            var sumV = 0.0;
            var sumG = 0.0;
            for (int i = 1; i <= fens; i++)
            {
                string text = Console.ReadLine().ToUpper();
                if (text == "A")
                    sumA += 1;
                if (text == "B")
                    sumB += 1;
                if (text == "V")
                    sumV += 1;
                if (text == "G")
                    sumG += 1;
           
            }
            var percentA = (sumA *100)/fens;
            var percentB = (sumB * 100)/fens;
            var percentV = (sumV * 100)/fens;
            var percentG = (sumG * 100)/fens;
            var percentFens = (fens* 100)/ totalStadium;
            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine("{0:f2}%", percentFens);
        }  
    }
}
