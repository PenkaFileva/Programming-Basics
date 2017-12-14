using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lengthcm = length * 100;
            var widthcm = width * 100;

            if ( 3<=width && width<=length && length<=100)
            {
                var workPlaces = Math.Truncate((widthcm - 100) / 70);
                var workRows = Math.Truncate(lengthcm / 120);
                var total = (workPlaces * workRows) - 3;
                Console.WriteLine(total);
            }
            else
            {

            }
        }
    }
}
