using System;

namespace Exercice_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez une valeur :");

            // Récupération d'une valeur saisie à la console
            string maxValue = Console.ReadLine();

            // Transformation du type chaine de caractères en entier
            int max = int.Parse(maxValue);

            for (int j = 1; j <= max; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (i == 77)
                        Console.Write("Buzz Buzz");
                    else if (i >= 71 && i <= 79)
                        Console.Write("Buzz");
                    else if (i % 5 == 0 && i % 3 == 0)
                        Console.Write("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.Write("Fizz");
                    else if (i % 5 == 0)
                        Console.Write("Buzz");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
    }
}
