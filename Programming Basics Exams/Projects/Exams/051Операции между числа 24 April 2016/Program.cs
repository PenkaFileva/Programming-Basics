using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051Операции_между_числа_24_April_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            string matOperator = Console.ReadLine();
            if (matOperator == "+" )
            {
                var deistvie = n1 + n2;
                if (deistvie % 2 == 0)
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - odd");
                }
            }
            else if (matOperator == "-")
            {
                var deistvie = n1 - n2;
                if (deistvie % 2 == 0)
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - odd");
                }
            }
            else if (matOperator == "*")
            {
                var deistvie = n1 * n2;
                if (deistvie % 2 == 0)
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {matOperator} {n2} = {deistvie} - odd");
                }
            }
            else if (matOperator == "/")
            {               
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    var deistvie = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {deistvie:f2}");
                }
            }
            else if (matOperator == "%")
            {               
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    var deistvie = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {deistvie}");
                }
            }
        }
    }
}
