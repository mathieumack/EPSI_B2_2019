﻿using System;

namespace Exercice_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parcours de 1 à 100
            for (int j = 1; j <= 100; j++)
            {
                // Parcours de 1 à j
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
