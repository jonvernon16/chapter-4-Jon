using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Please enter a number to determine if it's even or odd. ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry % 2 == 0)
            {
                Console.WriteLine("The number " + userEntry + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + userEntry + " is odd.");
            }
        }
    }
}
