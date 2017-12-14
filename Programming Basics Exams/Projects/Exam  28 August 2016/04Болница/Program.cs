using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var reviewedPatients = 0;
            var notReviewedPatients = 0;
            var doctors = 7;
            for (int i = 1; i <= days; i++)
            {
                var patients = int.Parse(Console.ReadLine());              
                if ( i % 3 == 0)
                {
                    if (notReviewedPatients > reviewedPatients)
                    {
                        doctors += 1;
                    }
                    if (patients >= doctors)
                    {
                        var diffPatients = patients - doctors;
                        reviewedPatients += doctors;
                        notReviewedPatients += diffPatients;
                    }
                    else if (patients < doctors)
                    {
                        reviewedPatients += patients;
                    }
                }
                else
                {
                    if (patients >= doctors)
                    {
                        var diffPatients = patients - doctors;
                        reviewedPatients += doctors;
                        notReviewedPatients += diffPatients;
                    }
                    else if (patients < doctors)
                    {
                        reviewedPatients += patients;
                    }
                }
            }
            Console.WriteLine($"Treated patients: {reviewedPatients}.");
            Console.WriteLine($"Untreated patients: {notReviewedPatients}.");
        }
    }
}
