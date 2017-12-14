using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            var intermediateCurrency = 0.0;
            if (inputCurrency == "BGN") 
            {
                intermediateCurrency = inputNumber;
            }
            else if (inputCurrency == "USD") 
            {
                intermediateCurrency = inputNumber * 1.79549;
            }
            else if (inputCurrency == "EUR") 
            {
                intermediateCurrency = inputNumber * 1.95583;
            }
            else if (inputCurrency == "GBP") 
            {
                intermediateCurrency = inputNumber * 2.53405;
            }
            var finalNumber = 0.0;
            if (outputCurrency == "BGN") 
            {
                finalNumber = intermediateCurrency;
            }
            else if (outputCurrency == "USD") 
            {
                finalNumber = intermediateCurrency / 1.79549;
            }
            else if (outputCurrency == "EUR") 
            {
                finalNumber = intermediateCurrency / 1.95583;
            }
            else if (outputCurrency == "GBP") 
            {
                finalNumber = intermediateCurrency / 2.53405;
            }
            Console.WriteLine($"{Math.Round(finalNumber, 2)} {outputCurrency}");
        }
    }
}
