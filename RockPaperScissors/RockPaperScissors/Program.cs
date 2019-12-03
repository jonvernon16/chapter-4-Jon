using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random ranRockPaperScissor = new Random();
            int randomRPS;
            randomRPS = ranRockPaperScissor.Next(1, 3);
            int userEntry;

            Console.WriteLine("Pick a number between 1-3 (1 = rock, 2 = paper 3 = scissors)");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                if (randomRPS == 1)
                {
                    Console.WriteLine("Well this is awkward I chose rock");
                }
                else if (randomRPS == 2)
                {
                    Console.WriteLine("Paper covers rock, you lose!");
                }
                else if (randomRPS == 3)
                {
                    Console.WriteLine("I lost, I chose scissors.");
                }
            }
            else if (userEntry == 2)
            {
                if (randomRPS == 1)
                {
                    Console.WriteLine("I lost, I chose Rock");
                }
                else if (randomRPS == 2)
                {
                    Console.WriteLine("I guess it's a tie, I chose paper.");
                }
                else if (randomRPS == 3)
                {
                    Console.WriteLine("I won, I chose scissors!");
                }
            }
            else if (userEntry == 3)
            {
                if (randomRPS == 1)
                {
                    Console.WriteLine("Rock smashes scissors, you lose!");
                }
                else if (randomRPS == 2)
                {
                    Console.WriteLine("I lost, I chose paper");
                }
                else if (randomRPS == 3)
                {
                    Console.WriteLine("It's a tie. I chose scissors");
                }
            }

            
        }
    }
}
