﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Odd_Even_Sum1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (var i = 1; i <= n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if ( i % 2 ==0)
                {
                    oddSum = oddSum + element;
                }
                else
                {
                    evenSum += element;
                }   
            }
            if (oddSum == evenSum )
            {
                Console.WriteLine("Yes, sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(oddSum - evenSum ));
            }
        }
    }
}