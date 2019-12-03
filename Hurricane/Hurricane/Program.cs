using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("What is the wind speed?");
            userEntry = Convert.ToInt32(Console.ReadLine());


            if (userEntry >= 74 && userEntry < 96)
            {
                Console.WriteLine("Thats a Cat. 1 hurricane.");
            }
            else if (userEntry >= 96 && userEntry < 111)
            {
                Console.WriteLine("Thats a Cat. 2 hurricane.");
            }
            else if (userEntry >= 111 && userEntry < 130)
            {
                Console.WriteLine("Thats a Cat. 3 hurricane.");
            }
            else if (userEntry >= 130 && userEntry < 157)
            {
                Console.WriteLine("Thats a Cat. 4 hurricane.");
            }
            else if (userEntry >= 157)
            {
                Console.WriteLine("Thats a Cat. 5 hurricane.");
            }
            else
            {
                Console.WriteLine("Thats just a storm.");
            }
        }
    }
}
