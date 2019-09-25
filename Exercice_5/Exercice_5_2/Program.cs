using System;

namespace Exercice_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] monTableau = new int[100];

            Console.WriteLine("Génération du tableau...");

            for (int i = 0; i < 100; i++)
            {
                monTableau[i] = random.Next(1, 6);
                Console.Write(monTableau[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Nettoyage du tableau...");
            for (int i = 0; i < 100; i++)
            {
                for (int j = i + 1; j < 100; j++)
                {
                    if (monTableau[i] == monTableau[j])
                        monTableau[j] = -1;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if (monTableau[i] != -1)
                    Console.Write(monTableau[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Tri du tableau...");

            int tmp;

            int taille = monTableau.Length;
            while (taille > 0)
            {
                for (int i = 0; i < taille - 1; i++)
                {
                    if (monTableau[i] > monTableau[i + 1])
                    {
                        tmp = monTableau[i];
                        monTableau[i] = monTableau[i + 1];
                        monTableau[i + 1] = tmp;
                    }
                }
                taille = taille - 1;
            }

            for (int i = 0; i < 100; i++)
            {
                if (monTableau[i] != -1)
                    Console.Write(monTableau[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
