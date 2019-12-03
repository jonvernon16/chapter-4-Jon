using System;

namespace _3NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int one;
            int two;
            int three;

            Console.WriteLine("Enter 3 numbers");
            one = Convert.ToInt32(Console.ReadLine());
            two = Convert.ToInt32(Console.ReadLine());
            three = Convert.ToInt32(Console.ReadLine());

            if (one < two)
            {
                if (one < two && two < three)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
