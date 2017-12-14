using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            bool a = (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday");
            bool b = (day == "saturday" || day == "sunday");
            bool c = (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" 
                || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes");
            if ( (a || b) && c)
            {
                if (quantity >= 0)
                {
                    var price = 0.0;
                    if (a)
                    {
                        if (fruit == "banana") price = 2.50;
                        else if (fruit == "apple") price = 1.20;
                        else if (fruit == "orange") price = 0.85;
                        else if (fruit == "grapefruit") price = 1.45;
                        else if (fruit == "kiwi") price = 2.70;
                        else if (fruit == "pineapple") price = 5.50;
                        else if (fruit == "grapes") price = 3.85;

                    }
                    else if (b)
                    {
                        if (fruit == "banana") price = 2.70;
                        else if (fruit == "apple") price = 1.25;
                        else if (fruit == "orange") price = 0.90;
                        else if (fruit == "grapefruit") price = 1.60;
                        else if (fruit == "kiwi") price = 3.00;
                        else if (fruit == "pineapple") price = 5.60;
                        else if (fruit == "grapes") price = 4.20;
                    }
                    Console.WriteLine("{0:0.00}",price * quantity);
                }
                else if ( quantity < 0)
                {
                    Console.WriteLine("error");
                }
            }
            else if ((a || b) && !c)
            {
                Console.WriteLine("error");
            }
            else if ((!a || !b) && c)
            {
                Console.WriteLine("error");
            }
            else if ((!a || !b) && !c)
            {
                Console.WriteLine("error");
            }
        }
    }
}
