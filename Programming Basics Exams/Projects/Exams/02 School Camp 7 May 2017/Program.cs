using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_School_Camp_7_May_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string group = Console.ReadLine().ToLower();
            var numStudents = double.Parse(Console.ReadLine());
            var numOvernight = double.Parse(Console.ReadLine());
            var price = 0.0;
            var percent =0.0;
            if (season == "winter")
            {
                if (group == "boys" || group == "girls")             
                    price = 9.60;                  
                else if (group == "mixed")
                    price = 10.0;
            }
            else if (season == "spring")
            {
                if (group == "boys" || group == "girls")
                    price = 7.20;
                else if (group == "mixed")
                    price = 9.50;
            }
            else if (season == "summer")
            {
                if (group == "boys" || group == "girls")
                    price = 15.0;
                else if (group == "mixed")
                    price = 20.0;
            }
            var sumHoliday = numStudents * numOvernight * price;
            if (numStudents == 10 && numStudents < 20)
                percent = 0.05;
            else if (numStudents >= 20 && numStudents < 50)
                percent = 0.15;
            else if (numStudents >= 50 )
                percent = 0.50;
            if (season == "winter")
            {
               switch(group)
                {
                    case "boys": Console.Write("Judo");break;
                    case "girls": Console.Write("Gymnastics");break;
                    case "mixed": Console.Write("Ski");break;
                }
            }
            else if (season == "spring")
            {
                switch(group)
                {
                    case "boys": Console.Write("Tennis"); break;
                    case "girls": Console.Write("Athletics"); break;
                    case "mixed": Console.Write("Cycling"); break;
                }
            }
            else if (season == "summer")
            {
                switch (group)
                {
                    case "boys": Console.Write("Football"); break;
                    case "girls": Console.Write("Volleyball"); break;
                    case "mixed": Console.Write("Swimming"); break;
                }
            }
            var totalHoliday = sumHoliday - (sumHoliday * percent);
            Console.WriteLine($" {totalHoliday:f2} lv.");
        }
    }
}
