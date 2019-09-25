using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> monTableau = Enumerable.Repeat(0, 100)    // Initialisation d'une liste de 100 items, initialisés à 0
                                                .Select(e => random.Next(1, 6)) // On transforme chaque élément de la liste par une valeur random
                                                .Distinct() // On filtre pour supprimer les doublons
                                                .OrderBy(e => e) // On tri par ordre croissant
                                                .ToList();  // On transforme le résultat en une liste

            // On concatènetoutes les valeurs en les séparant par un espace, puis on affichage la chaine dans la console
            string concatenationDesValeurs = string.Join(" ", monTableau);
            Console.WriteLine(concatenationDesValeurs);

            Console.ReadLine();
        }
    }
}
