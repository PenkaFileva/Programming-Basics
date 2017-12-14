using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numLecture = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var priceLecture = budget / numLecture;
            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trofon = 0;
            var sino = 0;
            var others = 0;

            for (int i = 1; i <= numLecture; i++)
            {
                string name = Console.ReadLine().ToLower();
                switch(name)
                {
                    case "jelev": jelev++;break;
                    case "royal": royal++; break;
                    case "roli": roli++; break;
                    case "trofon": trofon++; break;
                    case "sino": sino++; break;
                }
                if (name != "jelev" && name != "royal" && name != "roli" && name != "trofon" && name != "sino")
                {
                    others ++;
                }
            }
            Console.WriteLine($"Jelev salary: {(jelev*priceLecture):f2} lv");
            Console.WriteLine($"RoYaL salary: {(royal * priceLecture):f2} lv");
            Console.WriteLine($"Roli salary: {(roli * priceLecture):f2} lv");
            Console.WriteLine($"Trofon salary: {(trofon * priceLecture):f2} lv");
            Console.WriteLine($"Sino salary: {(sino * priceLecture):f2} lv");
            Console.WriteLine($"Others salary: {(others * priceLecture):f2} lv");
        }
    }
}