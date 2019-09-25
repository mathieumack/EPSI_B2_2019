using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parcours de 1 à 20 :
            for (int i = 1; i <= 20; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) // Multiple de 5 et 3
                    Console.Write("FizzBuzz");
                else if (i % 3 == 0) // Multiple de 3
                    Console.Write("Fizz");
                else if (i % 5 == 0) // Multiple de 5
                    Console.Write("Buzz");
                else
                    Console.Write(i);
            }

            Console.WriteLine("");
        }
    }
}
