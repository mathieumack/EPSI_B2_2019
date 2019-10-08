using System;
using System.Collections.Generic;

namespace Exercice_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Action, IActionComparateur> comparateurs = new Dictionary<Action, IActionComparateur>();
            comparateurs.Add(Action.Feuille, new FeuilleAction());
            comparateurs.Add(Action.Pierre, new PierreAction());
            comparateurs.Add(Action.Ciseaux, new CiseauxAction());
            comparateurs.Add(Action.Puit, new PuitAction());
            
            Console.WriteLine("Que veux-tu jouer ? (" + ((int)Action.Pierre) +
                                " = pierre, " + ((int)Action.Feuille) +
                                " = feuille, " + ((int)Action.Ciseaux) +
                                " = ciseaux et " + ((int)Action.Puit) +
                                " = puit)");

            Action actionUtilisateur = (Action)int.Parse(Console.ReadLine());

            Random random = new Random();
            Action actionOrdinateur = (Action)random.Next(0, 3);

            if (actionUtilisateur == actionOrdinateur)
                Console.WriteLine("Egalité");
            else
            {
                IActionComparateur comparateur = comparateurs[actionOrdinateur];
                bool gagne = comparateur.Gagne(actionUtilisateur);
                if(gagne)
                    Console.WriteLine("Tu as gagné");
                else
                    Console.WriteLine("Tu as perdu");
            }
        }
    }
}
