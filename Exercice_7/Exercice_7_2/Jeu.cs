using System;

namespace Exercice_7_2
{
    public class Jeu
    {
        public De de { get; set; }
        public Escargot[] escargots { get; set; }

        public Jeu()
        {
            int nbEscargots = 5;

            de = new De();
            escargots = new Escargot[nbEscargots];
            for (int i = 0; i < escargots.Length; i++)
            {
                Tortue tortue = new Tortue(de.Lancer(0, 4));
                escargots[i] = new Escargot(tortue);
            }
        }

        public void LancerCourse()
        {
            bool escargotArrive = false;

            while (!escargotArrive)
            {
                Console.WriteLine("Nouveau tour.");
                for (int i = 0; i < escargots.Length; i++)
                {
                    int valeurDe = de.Lancer();
                    escargots[i].Avancer(valeurDe);
                    escargotArrive = escargotArrive || escargots[i].EstArrive();
                    Console.WriteLine("Escargot " + i + " en position :" + escargots[i].Pas);
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
