using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;                                             // ще даде грешка ако потребителя въведе текст или не цяло число.
            //while (true)                                           // използва се try - catch да се хване грешката и да не се чупи програмата.
            //{
            //    Console.Write("Enter even number:");
            //    n = int.Parse(Console.ReadLine());
            //    if (n % 2 == 0)
            //        break;
            //    Console.WriteLine("The number is not even.");
            //}
            //Console.WriteLine("Even number entered: {0}", n);

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                      break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
