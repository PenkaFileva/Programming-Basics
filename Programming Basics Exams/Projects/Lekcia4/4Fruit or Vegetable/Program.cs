﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().ToLower();

            if ( a == "banana" || a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon" || a == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if ( a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
