using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Initialisation d'une liste vide
            List<int> monTableau = new List<int>();

            Console.WriteLine("Génération du tableau...");

            for (int i = 0; i < 100; i++)
            {
                // Ajout d'un élément dans la liste :
                monTableau.Add(random.Next(1, 6));
                // affichage de la valeur dans la console :
                Console.Write(monTableau[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Nettoyage du tableau...");
            // Suppression des doublons :
            IEnumerable<int> tableauNettoye = monTableau.Distinct();
            // Transformation sour la forme d'une liste de int :
            monTableau = tableauNettoye.ToList();

            Console.WriteLine("Tri du tableau...");

            // Tri des éléments :
            IEnumerable<int> tableauTrie = monTableau.OrderBy(e => e);
            // Transformation sour la forme d'une liste de int :
            monTableau = tableauTrie.ToList();

            // Affichage des éléments
            for (int i = 0; i < 100; i++)
            {
                if (monTableau[i] != -1)
                    Console.Write(monTableau[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
