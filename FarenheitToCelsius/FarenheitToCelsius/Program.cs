using System;

namespace FarenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int morning;
            int afternoon;
            int evening;
            int morningC;
            int afternoonC;
            int eveningC;

            Console.WriteLine("What was the tempeture yesterday morning in farenheit?");
            morning = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What was the tempeture yesterday afternoon in farenheit?");
            afternoon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What was the tempeture yesterday evening in farenheit?");
            evening = Convert.ToInt32(Console.ReadLine());

            if (morning <= 32 || afternoon <= 32 || evening <= 32)
            {
                Console.WriteLine("It was freezing.");
            }
            else if (morning >= 100 || afternoon >= 100 || evening >= 100)
            {
                Console.WriteLine("It was hot!");
            }

            morningC = (morning - 32) / (9 / 5);
            afternoonC = (afternoon - 32) / (9 / 5);
            eveningC = (evening - 32) / (9 / 5);

            Console.WriteLine(morningC);
            Console.WriteLine(afternoonC);
            Console.WriteLine(eveningC);


        }
    }
}
