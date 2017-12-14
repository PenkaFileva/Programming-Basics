using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string kategory = (Console.ReadLine().ToLower());
            var num = double.Parse(Console.ReadLine());
            var money = 0.0;
           
            if ( num <= 4)
            {
                money = 0.75 * budget;
            }
            else if ( num <= 9)
            {
                money = 0.60 * budget;
            }
            else if (num <= 24)
            {
                money = 0.50 * budget;
            }
            else if ( num <= 49)
            {
                money = 0.40 * budget;
            }
            else if (num >= 50)
            {
                money = 0.25 * budget;
            }
            var ticketSum = 0.0;
            var sumForTicket = budget - money;
            if (kategory == "vip")
            {
                 ticketSum = num * 499.99;
                var diff = ticketSum - sumForTicket;
                if (diff <= 0)
                {
                    diff = Math.Abs(diff);
                    Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                }
                else if (diff > 0)
                {
                    Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                }
            }
            else if (kategory == "normal")
            {
                 ticketSum = num * 249.99;
                var diff = ticketSum - sumForTicket;
                if (diff <= 0)
                {
                    diff = Math.Abs(diff);
                    Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                }
                else if (diff > 0)
                {
                    Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                }
            }          
        }
    }
}
