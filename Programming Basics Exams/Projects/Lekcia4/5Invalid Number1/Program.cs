﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Invalid_Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var inRange = (a >= 100 && a <= 200 || a == 0);
            if ( ! inRange)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}