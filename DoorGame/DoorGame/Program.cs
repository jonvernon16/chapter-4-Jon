using System;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry; 

            Console.WriteLine("Pick door 1, 2, or 3");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                Console.WriteLine("Well great job, you die guy.");
            }
            else if (userEntry == 2)
            {
                Console.WriteLine("You get a beagle. Nice");
            }
            else if (userEntry == 3)
            {
                Console.WriteLine("Nice pile of dirt, haha.");
            }
            else
            {
                Console.WriteLine("You are dumb.");
            }
            
        }
    }
}
