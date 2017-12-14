using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = "s3cr3t!P@ssw0rd";
            if (text == text1)
            {
                Console.WriteLine("Welcome");
            }
            else if(text != text1)
            {
                Console.WriteLine("Wrong password!");
            }
            
        }
    }
}
