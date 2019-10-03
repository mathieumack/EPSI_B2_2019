using System;

namespace Exercice_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IActionComparateur[] comparateurs = new IActionComparateur[4];
            comparateurs[0] = new FeuilleAction();
            comparateurs[1] = new PierreAction();
            comparateurs[2] = new CiseauxAction();
            comparateurs[3] = new PuitAction();

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
                IActionComparateur comparateur = null;
                for (int i = 0; i < comparateurs.Length; i++)
                {
                    if (comparateurs[i].ActionDefinition == actionOrdinateur)
                        comparateur = comparateurs[i];
                }

                bool gagne = comparateur.Gagne(actionUtilisateur);
                if(gagne)
                    Console.WriteLine("Tu as gagné");
                else
                    Console.WriteLine("Tu as perdu");
            }
        }
    }
}
