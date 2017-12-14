using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2On_Time_for_the_Exam_6_Mart_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMin = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMin;
            int studentTime = studentHour * 60 + studentMin;
            int diff = studentTime - examTime;

            if (diff<-30)
                Console.WriteLine("Early");
            else if(diff<=0)
                Console.WriteLine("On time");
            else 
                Console.WriteLine("Late");
            if (diff != 0)
            {
                int hour = Math.Abs(diff) / 60;
                int min = Math.Abs(diff) % 60;
                if(hour>0)
                    Console.Write("{0}:{1:00} hours ", hour, min);
                else
                    Console.Write("{0} minutes ", min);
                if(diff<0)
                    Console.WriteLine("before the start");
                else
                    Console.WriteLine("after the start");
            }
        }
    }
}
