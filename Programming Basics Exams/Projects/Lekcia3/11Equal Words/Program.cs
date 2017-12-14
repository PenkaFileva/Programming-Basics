using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = Console.ReadLine();

            if (text.ToLower() == text1.ToLower())
            {
                Console.WriteLine("yes");
            }
            else if ( text.ToLower() != text1.ToLower())
            {
                Console.WriteLine("no");
            }
        }
    }
}
