using System;

namespace Exercice_7_3
{
    public class Jeu
    {
        public De de { get; set; }
        public Escargot[] escargots { get; set; }

        public Jeu()
        {
            de = new De();
        }

        public void LancerCourse()
        {
            bool escargotArrive = false;

            Console.WriteLine("Saisissez le nombre d'escargots :");
            int nbEscargots = int.Parse(Console.ReadLine());

            escargots = new Escargot[nbEscargots];
            for (int i = 0; i < escargots.Length; i++)
            {
                Console.WriteLine("Saisissez le nom de l'escargot " + i);
                string nom = Console.ReadLine();

                Tortue tortue = new Tortue(de.Lancer(0, 4));
                escargots[i] = new Escargot(tortue, nom);
            }

            while (!escargotArrive)
            {
                Console.WriteLine("Nouveau tour.");
                for (int i = 0; i < escargots.Length; i++)
                {
                    int valeurDe = de.Lancer();
                    escargots[i].Avancer(valeurDe);
                    escargotArrive = escargotArrive || escargots[i].EstArrive();
                    Console.WriteLine("Escargot " + escargots[i].Nom + " en position :" + escargots[i].Pas);
                }
            }

            for (int i = 0; i < escargots.Length; i++)
            {
                if (escargots[i].EstArrive())
                    Console.WriteLine("Escargot " + i + " arrivé !");
            }
        }
    }
}
