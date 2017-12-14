using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
 
            for (int i = 1; i <= 9 ; i++)
            {
                for (int j = 1; j <= 9; j++)
                {   
                    for (int k = 1; k <= 9 ; k++)
                    {
                        for (int q = 1; q <= 9; q++)
                        {
                            if (n%i == 0 && n%j == 0 && n%k == 0 && n%q == 0 )
                            {
                                Console.Write($"{i}{j}{k}{q} ");
                            }
  
                        }                             
                    }       
                }               
            }
        }
    }
}
