using System;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int charLimit;

            Console.WriteLine("Welcome to twitter, Enter a tweet.");
            userMessage = Console.ReadLine();

            charLimit = userMessage.Length;

            if (charLimit >= 140)
            {
                Console.WriteLine("Please enter another tweet, the character limit is 140");
            }
            else
            {
                Console.WriteLine("Message Uploaded");
            }
        }
    }
}
