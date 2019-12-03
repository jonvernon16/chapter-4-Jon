using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userEntry;
            int rndNumber = rnd.Next(1, 10);
            string choice;
            Console.WriteLine("Pick a number between 1 and 10");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber)
            {
                Console.WriteLine("How did you know?");
                Console.WriteLine("Would you like to go for double or nothing?");
                choice = Console.ReadLine();
                if (choice.Equals("Yes"))
                {
                    Console.WriteLine("Congratulations you are a degenerate gambler.");
                }
                else
                {
                    Console.WriteLine("Way to quit when you're ahead.");
                }
            }
            else
            {
                Console.WriteLine("{0} was incorect ", userEntry);
            }
        }
    }
}
