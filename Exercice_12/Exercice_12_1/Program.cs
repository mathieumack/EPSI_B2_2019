using System;

namespace Exercice_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableau = new int[10, 10];
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tableau[i, j] = random.Next(10);
                }
            }

            // Affichage du tableau :
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tableau[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            // Inversion
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    int valueB = tableau[j, i];
                    tableau[j, i] = tableau[i, j];
                    tableau[i, j] = valueB;
                }
            }

            // Affichage du tableau :
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tableau[i, j]);
                }
                Console.WriteLine("");
            }

        }
    }
}
