using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_6_1
{
    public class BaseLivre : IBaseLivre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
    }

    public class Livre : BaseLivre
    {
        public string Titre { get; set; }
        public int AnneePublication { get; set; }
        public string Auteur { get; set; }

        public void AfficherDetails()
        {
            Console.WriteLine("Titre : " + Titre);
            Console.WriteLine("Année : " + AnneePublication);
        }
    }

    public interface IBaseLivre
    {
        /// <summary>
        /// Titre du livre
        /// </summary>
        string Titre { get; set; }

        //Auteur
        string Auteur { get; set; }
    }

    public interface ILivre : IBaseLivre
    {
        /// <summary>
        /// Année de publication
        /// </summary>
        int AnneePublication { get; set; }

        /// <summary>
        /// Affiche les détails du livre
        /// </summary>
        void AfficherDetails();
    }
}
