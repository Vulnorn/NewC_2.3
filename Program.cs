using System;

namespace NewC_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 5;
            int maxNumber = 103;
            int stepSequence = 7;
            int number = minNumber;

            while (number <= maxNumber)
            {
                Console.Write($"{number} ");
                number = number + stepSequence;
            }

            Console.ReadKey();
        }
    }
}