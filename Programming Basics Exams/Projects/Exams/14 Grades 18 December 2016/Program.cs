using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Grades_18_December_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var numStudents = int.Parse(Console.ReadLine());
            var counter2 = 0.0;
            var counter3 = 0.0;
            var counter4 = 0.0;
            var counter5 = 0.0;
            var sumEstimates = 0.0;

            for (int i = 1; i <= numStudents; i++)
            {
                var examEvaluation = double.Parse(Console.ReadLine());
                sumEstimates += examEvaluation;
                if (examEvaluation>= 2.00 && examEvaluation<=2.99)
                {
                    counter2 += 1;
                }
                else if (examEvaluation >= 3.00 && examEvaluation <= 3.99)
                {
                    counter3 += 1;
                }
                else if (examEvaluation >= 4.00 && examEvaluation <= 4.99)
                {
                    counter4 += 1;
                }
                else if (examEvaluation >= 5.00 && examEvaluation <= 6.00)
                {
                    counter5 += 1;
                }
            }
            var percentCounter5 = (counter5 / numStudents) * 100;
            var percentCounter4 = (counter4 / numStudents) * 100;
            var percentCounter3 = (counter3 / numStudents) * 100;
            var percentCounter2 = (counter2 / numStudents) * 100;
            var averageGrade = sumEstimates / numStudents;

            Console.WriteLine($"Top students: {percentCounter5:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentCounter4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentCounter3:f2}%");
            Console.WriteLine($"Fail: {percentCounter2:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
