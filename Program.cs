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

            for (int i = minNumber; i <= maxNumber; i=i+stepSequence)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}