using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int randomNumber;
            randomNumber = randomNum.Next(1, 10);

            int userInput;

            Console.WriteLine("Enter a number between 1 - 10.");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == randomNumber)
            {
                Console.WriteLine("How'd you know? {0}", randomNumber);
            }
            else
            {
                Console.WriteLine("You're wrong, the answer is {0}", randomNumber);
            }
        }
    }
}
