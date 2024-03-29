﻿using System;

namespace Exercice_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que veux-tu jouer ? (" + ((int)Action.Pierre) +
                                " = pierre, " + ((int)Action.Feuille) +
                                " = feuille, " + ((int)Action.Ciseaux) +
                                " = puit)");

            Action actionUtilisateur = (Action)int.Parse(Console.ReadLine());

            Random random = new Random();
            Action actionOrdinateur = (Action)random.Next(0, 3);

            if (actionUtilisateur == actionOrdinateur)
                Console.WriteLine("Egalité");
            else
            {
                bool gagne = (actionUtilisateur == Action.Pierre && actionOrdinateur == Action.Ciseaux) ||
                                (actionUtilisateur == Action.Feuille && actionOrdinateur == Action.Pierre) ||
                                (actionUtilisateur == Action.Ciseaux && actionOrdinateur == Action.Feuille);
                if (gagne)
                    Console.WriteLine("Tu as gagné");
                else
                    Console.WriteLine("Tu as perdu");
            }
        }
    }
}
