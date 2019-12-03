using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEntryGPA;
            int userEntryTestScore;

            Console.WriteLine("Please enter your GPA ");
            userEntryGPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your test score ");
            userEntryTestScore = Convert.ToInt32(Console.ReadLine());

            if (userEntryGPA >= 3.0 && userEntryTestScore >= 60)
            {
                Console.WriteLine("Accepted");
            }
            else if (userEntryGPA >= 3.0 && userEntryTestScore >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
    }
}
