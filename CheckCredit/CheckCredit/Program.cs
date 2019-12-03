using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEntry;

            Console.WriteLine("Please enter a puchase price of an item.");
            userEntry = Convert.ToDouble(Console.ReadLine());

            if (userEntry >= 5000)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Accepted");
            }
        }
    }
}
