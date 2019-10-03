using System;

namespace Exercice_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IActionComparateur[] comparateurs = new IActionComparateur[3];
            comparateurs[0] = new FeuilleAction();
            comparateurs[1] = new PierreAction();
            comparateurs[2] = new CiseauxAction();

            Console.WriteLine("Que veux-tu jouer ? (" + ((int)Action.Pierre) +
                                " = pierre, " + ((int)Action.Feuille) +
                                " = feuille et " + ((int)Action.Ciseaux) +
                                " = ciseaux)");

            string actionUtilisateur = Console.ReadLine();
            Action actionAJouer = (Action)int.Parse(actionUtilisateur);

            Action actionOrdinateur = Action.Feuille;

            if (actionAJouer == actionOrdinateur)
            {
                Console.WriteLine("Egalité");
            }
            else
            {
                IActionComparateur comparateur = null;
                for (int i = 0; i < comparateurs.Length; i++)
                {
                    if (comparateurs[i].ActionDefinition == actionOrdinateur)
                        comparateur = comparateurs[i];
                }

                bool gagne = comparateur.Gagne(actionAJouer);
                if(gagne)
                    Console.WriteLine("Tu as gagné");
                else
                    Console.WriteLine("Tu as perdu");
            }
        }
    }
}
