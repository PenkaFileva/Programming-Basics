using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;
            for (int i =0 ; i <= text.Length-1; i++)
            {
                switch (text[i])
                {
                    case 'a': Console.WriteLine(sum+=1); break;
                    case 'e': Console.WriteLine(sum+=2); break;
                    case 'i': Console.WriteLine(sum+=3); break;
                    case 'o': Console.WriteLine(sum+=4); break;
                    case 'u': Console.WriteLine(sum+=5); break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
