using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_6_1
{
    public class Bibliotheque
    {
        public Livre[] Livres { get; private set; }

        public Bibliotheque()
        {
            Livres = new Livre[10];
        }

        public void Start()
        {
            Console.WriteLine("Que souhaitez-vous faire ? (0 = Ajouter un livre)");
            string action = Console.ReadLine();
            while (action != "exit")
            {
                if (action == "0")
                    AjouterLivre();
                else if (action == "1")
                    AfficherLivres();
                else if (action == "2")
                    SupprimeLivre();

                Console.WriteLine("Que souhaitez-vous faire ? (0 = Ajouter un livre)");
                action = Console.ReadLine();
            }
        }

        private void AjouterLivre()
        {
            int index = IndexLibre();
            if (index == -1)
                Console.WriteLine("Bibliothèque pleine");
            else
            {
                Console.WriteLine("Quel est le titre ?");
                string titre = Console.ReadLine();
                Console.WriteLine("Quel est l'année de publication ?");
                int annee = int.Parse(Console.ReadLine());

                Livre nouveauLivre = new Livre(titre, annee);
                Livres[index] = nouveauLivre;
            }
        }

        private int IndexLibre()
        {
            int i = 0;
            while(i < Livres.Length && Livres[i] != null)
            {
                i++;
            }
            if (i < Livres.Length)
                return i;
            return -1;
        }

        private void SupprimeLivre()
        {
            Console.WriteLine("Quel est le numéro du livre ?");
            int index = int.Parse(Console.ReadLine());
            Livres[index] = null;
        }

        private void AfficherLivres()
        {
            for(int i = 0; i < Livres.Length; i++)
            {
                if (Livres[i] != null)
                {
                    Console.WriteLine("Livre " + i);
                    Livres[i].AfficherDetails();
                }
            }
        }
    }
}
