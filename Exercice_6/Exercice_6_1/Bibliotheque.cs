using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_6_1
{
    public class Bibliotheque
    {
        public List<Livre> Livres { get; private set; }

        public Bibliotheque()
        {
            Livres = new List<Livre>();
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
            Console.WriteLine("Quel est le titre ?");
            string titre = Console.ReadLine();
            Console.WriteLine("Quel est l'année de publication ?");
            int annee = int.Parse(Console.ReadLine());

            Livre nouveauLivre = new Livre(titre, annee);
            Livres.Add(nouveauLivre);
        }

        private void SupprimeLivre()
        {
            Console.WriteLine("Quel est le numéro du livre ?");
            int index = int.Parse(Console.ReadLine());
            Livres.RemoveAt(index);
        }

        private void AfficherLivres()
        {
            for(int i = 0; i < Livres.Count; i++)
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
