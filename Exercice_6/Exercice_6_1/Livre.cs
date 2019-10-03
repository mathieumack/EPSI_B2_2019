using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_6_1
{
    public class Livre
    {
        public string Titre { get; private set; }

        public int AnneePublication { get; private set; }

        public Livre(string titre, int anneePublication)
        {
            Titre = titre;
            AnneePublication = anneePublication;
        }

        public void AfficherDetails()
        {
            Console.WriteLine("      titre : " +Titre);
            Console.WriteLine("      année : " + AnneePublication);
        }
    }
}
